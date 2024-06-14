using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;

namespace PVRL
{
    public partial class CraftingForm : Form
    {
        private List<Character> characters;
        private Vault vault;
        private Dictionary<string, string> selectedParts; // To store selected parts for crafting

        public CraftingForm(List<Character> characters, Vault vault)
        {
            InitializeComponent();
            this.characters = characters;
            this.vault = vault;
            this.selectedParts = new Dictionary<string, string>
            {
                { "UpperReceiver", null },
                { "Barrel", null },
                { "LowerReceiver", null },
                { "BufferTube", null },
                { "Stock", null },
                { "Grip", null },
                { "Trigger", null }
            };

            LoadCharacters();
            LoadVault();
            LoadQualityComboBox();
            LoadParts();
            LoadRepairItems();
        }

        private void LoadCharacters()
        {
            characterListBox.Items.Clear();
            foreach (var character in characters)
            {
                characterListBox.Items.Add(character.Name);
            }
        }

        private void LoadVault()
        {
            vaultListBox.Items.Clear();
            foreach (var gun in vault.Guns)
            {
                vaultListBox.Items.Add(gun.ID);
            }
        }

        private void LoadQualityComboBox()
        {
            partQualityComboBox.Items.Clear();
            partQualityComboBox.Items.Add("Poor");
            partQualityComboBox.Items.Add("Standard");
            partQualityComboBox.Items.Add("Superior");
            partQualityComboBox.Items.Add("First-rate");
        }

        private void LoadParts()
        {
            partsListBox.Items.Clear();
            foreach (var partType in vault.Parts.Keys)
            {
                foreach (var quality in vault.Parts[partType].Keys)
                {
                    foreach (var part in vault.Parts[partType][quality])
                    {
                        partsListBox.Items.Add($"{partType} ({quality}): {part}");
                    }
                }
            }
        }

        private void LoadRepairItems()
        {
            repairItemsListBox.Items.Clear();
            foreach (var item in vault.RepairItems)
            {
                repairItemsListBox.Items.Add($"{item.Name}");
            }
        }

        private void characterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                characterGunLabel.Text = selectedCharacter.Gun != null ? selectedCharacter.Gun.ID : "No Gun Equipped";
                LoadCharacterGunDetails(selectedCharacter);
            }
        }

        private void LoadCharacterGunDetails(Character selectedCharacter)
        {
            if (selectedCharacter.Gun != null)
            {
                characterGunDetailsTextBox.Text = selectedCharacter.Gun.ToString().Replace("\n", Environment.NewLine);
                gunNameTextBox.Text = selectedCharacter.Gun.Name;
            }
            else
            {
                characterGunDetailsTextBox.Clear();
                gunNameTextBox.Clear();
            }
        }

        private void vaultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vaultListBox.SelectedIndex >= 0)
            {
                var selectedGun = vault.Guns[vaultListBox.SelectedIndex];
                vaultGunDetailsTextBox.Text = selectedGun.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void disassembleGunButton_Click(object sender, EventArgs e)
        {
            if (vaultListBox.SelectedIndex >= 0)
            {
                var selectedGun = vault.Guns[vaultListBox.SelectedIndex];
                vault.RemoveGun(selectedGun);
                vault.AddParts(selectedGun);
                LoadVault();
                LoadParts();
                SaveVault();
                MessageBox.Show("Gun disassembled and parts added to the vault.");
            }
            else if (characterListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                if (selectedCharacter.Gun != null)
                {
                    var gunToDisassemble = selectedCharacter.Gun;
                    selectedCharacter.Gun = null;
                    vault.AddParts(gunToDisassemble);
                    LoadCharacterGunDetails(selectedCharacter);
                    SaveCharacter(selectedCharacter);
                    LoadParts();
                    MessageBox.Show("Gun disassembled and parts added to the vault.");
                }
                else
                {
                    MessageBox.Show("Selected character has no gun equipped.");
                }
            }
        }

        private void upgradeGunButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0 && partTypeComboBox.SelectedItem != null && partQualityComboBox.SelectedItem != null)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                string selectedPartType = partTypeComboBox.SelectedItem.ToString();
                string selectedQuality = partQualityComboBox.SelectedItem.ToString();

                if (selectedCharacter.Gun != null && vault.HasPart(selectedPartType, selectedQuality))
                {
                    selectedCharacter.Gun.UpgradePart(vault.GetPart(selectedPartType, selectedQuality), selectedPartType);
                    LoadCharacterGunDetails(selectedCharacter);
                    SaveCharacter(selectedCharacter);
                    SaveVault();
                    MessageBox.Show("Gun upgraded with new part.");
                    LoadParts();
                }
                else
                {
                    MessageBox.Show("Selected part is not available in the vault.");
                }
            }
        }

        private void renameGunButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0 && !string.IsNullOrEmpty(gunNameTextBox.Text))
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                selectedCharacter.Gun.Name = gunNameTextBox.Text;
                LoadCharacterGunDetails(selectedCharacter);
                SaveCharacter(selectedCharacter);
            }
        }

        private void craftGunButton_Click(object sender, EventArgs e)
        {
            if (selectedParts.Values.All(part => part != null))
            {
                var gunName = craftedGunNameTextBox.Text; // Use the name from the text box
                if (string.IsNullOrEmpty(gunName))
                {
                    MessageBox.Show("Please enter a name for the crafted gun.");
                    return;
                }

                var gun = new GunGeneration.Gun(
                    id: Guid.NewGuid().ToString().Substring(0, 8),
                    origin: GunGeneration.GunOrigin.Civilian,
                    type: GunGeneration.GunType.Medium,
                    upperReceiver: selectedParts["UpperReceiver"],
                    barrel: selectedParts["Barrel"],
                    lowerReceiver: selectedParts["LowerReceiver"],
                    bufferTube: selectedParts["BufferTube"],
                    stock: selectedParts["Stock"],
                    grip: selectedParts["Grip"],
                    trigger: selectedParts["Trigger"],
                    damage: 10, // Example value
                    accuracy: 50, // Example value
                    range: 100, // Example value
                    fireRate: 10, // Example value
                    weight: 5.0f, // Example value
                    price: 100, // Example value
                    name: gunName // Use the entered gun name
                );

                vault.AddGun(gun);
                RemoveUsedPartsFromVault();
                SaveVault();
                MessageBox.Show("Gun crafted successfully!");

                // Clear the selected parts for next crafting
                foreach (var key in selectedParts.Keys.ToList())
                {
                    selectedParts[key] = null;
                }
                craftedGunNameTextBox.Clear();
                LoadSelectedParts();
            }
            else
            {
                MessageBox.Show("Please add all parts to craft a gun.");
            }
        }

        private void RemoveUsedPartsFromVault()
        {
            foreach (var partType in selectedParts.Keys)
            {
                var part = selectedParts[partType];
                var quality = part.Split(' ')[1].TrimEnd(':');
                vault.RemovePart(partType, quality, part);
            }
        }

        private void SaveCharacter(Character character)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, JsonConvert.SerializeObject(character));
        }

        private void SaveVault()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vault", "vault.json");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, JsonConvert.SerializeObject(vault));
        }

        private void partsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (partsListBox.SelectedItem != null)
            {
                partsListBox.DoDragDrop(partsListBox.SelectedItem, DragDropEffects.Move);
            }
        }

        private void partSlot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void partSlot_DragDrop(object sender, DragEventArgs e)
        {
            var slot = sender as TextBox;
            var partInfo = e.Data.GetData(DataFormats.StringFormat).ToString();
            var partType = partInfo.Split(' ')[0]; // Extract part type

            if (selectedParts.ContainsKey(partType))
            {
                var slotType = slot.Tag.ToString();
                if (slotType == partType)
                {
                    selectedParts[partType] = partInfo;
                    slot.Text = partInfo;
                }
                else
                {
                    MessageBox.Show($"Please drop a {slotType} part into this slot.");
                }
            }
        }

        private void LoadSelectedParts()
        {
            upperReceiverTextBox.Clear();
            barrelTextBox.Clear();
            lowerReceiverTextBox.Clear();
            bufferTubeTextBox.Clear();
            stockTextBox.Clear();
            gripTextBox.Clear();
            triggerTextBox.Clear();

            if (selectedParts["UpperReceiver"] != null) upperReceiverTextBox.Text = selectedParts["UpperReceiver"];
            if (selectedParts["Barrel"] != null) barrelTextBox.Text = selectedParts["Barrel"];
            if (selectedParts["LowerReceiver"] != null) lowerReceiverTextBox.Text = selectedParts["LowerReceiver"];
            if (selectedParts["BufferTube"] != null) bufferTubeTextBox.Text = selectedParts["BufferTube"];
            if (selectedParts["Stock"] != null) stockTextBox.Text = selectedParts["Stock"];
            if (selectedParts["Grip"] != null) gripTextBox.Text = selectedParts["Grip"];
            if (selectedParts["Trigger"] != null) triggerTextBox.Text = selectedParts["Trigger"];
        }

        private void repairButton_Click(object sender, EventArgs e)
        {
            // Implement the repair button click logic
        }

        private void CraftingForm_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void triggerTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

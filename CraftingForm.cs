using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Main;

namespace PVRL
{
    public partial class CraftingForm : Form
    {
        private List<Character> characters;
        private Vault vault;

        public CraftingForm(List<Character> characters, Vault vault)
        {
            InitializeComponent();
            this.characters = characters;
            this.vault = vault;
            LoadCharacters();
            LoadVault();
            LoadQualityComboBox();
            LoadParts();
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

        private void SaveCharacter(Character character)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(character));
        }

        private void SaveVault()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vault", "vault.json");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(vault));
        }
    }
}

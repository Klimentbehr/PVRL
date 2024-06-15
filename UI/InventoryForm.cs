using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PVRL
{
    public partial class InventoryForm : Form
    {
        private List<Character> characters;
        private Vault vault;

        public InventoryForm(List<Character> characters, Vault vault)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.characters = characters;
            this.vault = vault;
            LoadCharacters();
            LoadVault();
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
            vaultGunsListBox.Items.Clear();
            vaultArmorsListBox.Items.Clear();
            foreach (var gun in vault.Guns)
            {
                vaultGunsListBox.Items.Add(gun.ID);
            }
            foreach (var armor in vault.Armors)
            {
                vaultArmorsListBox.Items.Add(armor.ID);
            }
        }

        private void characterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                characterGunLabel.Text = selectedCharacter.Gun != null ? selectedCharacter.Gun.ID : "No Gun Equipped";
                characterVestLabel.Text = selectedCharacter.Armors.Count > 0 ? selectedCharacter.Armors[0].ID : "No Vest Equipped";
                characterHelmetLabel.Text = selectedCharacter.Armors.Count > 1 ? selectedCharacter.Armors[1].ID : "No Helmet Equipped";
                characterWalletLabel.Text = $"Wallet: {selectedCharacter.Wallet}";
                characterLevelLabel.Text = $"Level: {selectedCharacter.Level}";
                characterExperienceLabel.Text = $"Experience: {selectedCharacter.ExperiencePoints}";
                LoadCharacterHealingItems(selectedCharacter);
            }
        }

        private void vaultGunsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vaultGunsListBox.SelectedIndex >= 0)
            {
                var selectedGun = vault.Guns[vaultGunsListBox.SelectedIndex];
                vaultGunDetailsTextBox.Text = selectedGun.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void vaultArmorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vaultArmorsListBox.SelectedIndex >= 0)
            {
                var selectedArmor = vault.Armors[vaultArmorsListBox.SelectedIndex];
                vaultArmorDetailsTextBox.Text = selectedArmor.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void equipGunButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0 && vaultGunsListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                var selectedGun = vault.Guns[vaultGunsListBox.SelectedIndex];

                if (selectedCharacter.Gun != null)
                {
                    vault.AddGun(selectedCharacter.Gun);
                }

                selectedCharacter.Gun = selectedGun;
                vault.RemoveGun(selectedGun);

                characterGunLabel.Text = selectedGun.ID;
                LoadVault();
                SaveCharacter(selectedCharacter);
            }
        }

        private void equipArmorButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0 && vaultArmorsListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];
                var selectedArmor = vault.Armors[vaultArmorsListBox.SelectedIndex];

                selectedCharacter.EquipArmor(selectedArmor);
                vault.RemoveArmor(selectedArmor);

                characterVestLabel.Text = selectedCharacter.Armors.Count > 0 ? selectedCharacter.Armors[0].ID : "No Vest Equipped";
                characterHelmetLabel.Text = selectedCharacter.Armors.Count > 1 ? selectedCharacter.Armors[1].ID : "No Helmet Equipped";
                LoadVault();
                SaveCharacter(selectedCharacter);
            }
        }

        private void storeGunButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];

                if (selectedCharacter.Gun != null)
                {
                    vault.AddGun(selectedCharacter.Gun);
                    selectedCharacter.Gun = null;

                    characterGunLabel.Text = "No Gun Equipped";
                    LoadVault();
                    SaveCharacter(selectedCharacter);
                }
            }
        }

        private void storeArmorButton_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex >= 0)
            {
                var selectedCharacter = characters[characterListBox.SelectedIndex];

                if (selectedCharacter.Armors.Count > 0)
                {
                    var armorToStore = selectedCharacter.Armors[0];
                    vault.AddArmor(armorToStore);
                    selectedCharacter.UnequipArmor(armorToStore);

                    characterVestLabel.Text = selectedCharacter.Armors.Count > 0 ? selectedCharacter.Armors[0].ID : "No Vest Equipped";
                    characterHelmetLabel.Text = selectedCharacter.Armors.Count > 1 ? selectedCharacter.Armors[1].ID : "No Helmet Equipped";
                    LoadVault();
                    SaveCharacter(selectedCharacter);
                }
            }
        }

        private void LoadCharacterHealingItems(Character character)
        {
            characterHealingItemsListBox.Items.Clear();
            foreach (var item in character.HealingItems)
            {
                characterHealingItemsListBox.Items.Add(item.Name);
            }
        }

        private void SaveCharacter(Character character)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(character));
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
        }

        private void characterExperienceLabel_Click(object sender, EventArgs e)
        {
        }

        private void characterLevelLabel_Click(object sender, EventArgs e)
        {
        }

        private void characterWalletLabel_Click(object sender, EventArgs e)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Main;
using Newtonsoft.Json;

namespace PVRL
{
    public partial class StoreForm : Form
    {
        private List<GunGeneration.Gun> gunsForSale;
        private List<ArmorGeneration.Armor> armorsForSale;
        private Character player;
        private Vault vault;

        public StoreForm(Character player, Vault vault)
        {
            InitializeComponent();
            this.player = player;
            this.vault = vault;
            LoadGunsForSale();
            LoadArmorsForSale();
            LoadPlayerGuns();
            LoadPlayerHealingItems();
            LoadPlayerArmors();
            UpdateWalletLabel();
        }

        private void UpdateWalletLabel()
        {
            walletLabel.Text = $"Wallet: {player.Wallet} credits";
        }

        private void LoadGunsForSale()
        {
            try
            {
                gunsForSale = LoadGunsFromFile();
                if (gunsForSale.Count > 10)
                {
                    gunsForSale = gunsForSale.OrderBy(x => Guid.NewGuid()).Take(10).ToList(); // Randomly select 10 guns
                }

                gunsListBox.Items.Clear();
                foreach (var gun in gunsForSale)
                {
                    gunsListBox.Items.Add($"{gun.Name} - Price: {gun.Price}");
                }

                // Debug information
                if (gunsForSale.Count == 0)
                {
                    MessageBox.Show("No guns loaded for sale.");
                }
                else
                {
                    MessageBox.Show($"{gunsForSale.Count} guns loaded for sale.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guns for sale: {ex.Message}");
            }
        }

        private List<GunGeneration.Gun> LoadGunsFromFile()
        {
            List<GunGeneration.Gun> guns = new List<GunGeneration.Gun>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GeneratedFiles", "Guns.txt");
                if (File.Exists(filePath))
                {
                    string[] gunLines = File.ReadAllLines(filePath);
                    foreach (string line in gunLines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var gun = JsonConvert.DeserializeObject<GunGeneration.Gun>(line);
                            if (gun != null)
                            {
                                guns.Add(gun);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Guns.txt file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guns from file: {ex.Message}");
            }
            return guns;
        }


        private void LoadArmorsForSale()
        {
            try
            {
                armorsForSale = ArmorGeneration.GenerateRandomArmors(10); // Generate 10 random armor items

                armorsListBox.Items.Clear();
                foreach (var armor in armorsForSale)
                {
                    armorsListBox.Items.Add($"{armor.Name} - Price: {armor.Price}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading armors for sale: {ex.Message}");
            }
        }

        private void LoadPlayerGuns()
        {
            playerGunsListBox.Items.Clear();
            foreach (var gun in player.Inventory)
            {
                playerGunsListBox.Items.Add($"{gun.Name} - Sell Price: {gun.Price / 2}");
            }

            // Load guns from the vault as well
            foreach (var gun in vault.Guns)
            {
                playerGunsListBox.Items.Add($"{gun.Name} - Sell Price: {gun.Price / 2}");
            }
        }

        private void LoadPlayerHealingItems()
        {
            playerHealingItemsListBox.Items.Clear();
            foreach (var item in player.HealingItems)
            {
                playerHealingItemsListBox.Items.Add($"{item.Name}");
            }

            // Load healing items from the vault as well
            foreach (var item in vault.HealingItems)
            {
                playerHealingItemsListBox.Items.Add($"{item.Name}");
            }
        }

        public void LoadPlayerArmors()
        {
            playerArmorsListBox.Items.Clear();
            foreach (var armor in player.Armors)
            {
                playerArmorsListBox.Items.Add($"{armor.Name} - Sell Price: {armor.Price / 2}");
            }

            // Load armors from the vault as well
            foreach (var armor in vault.Armors)
            {
                playerArmorsListBox.Items.Add($"{armor.Name} - Sell Price: {armor.Price / 2}");
            }
        }

        private void gunsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunsListBox.SelectedIndex >= 0)
            {
                var selectedGun = gunsForSale[gunsListBox.SelectedIndex];
                gunDetailsTextBox.Text = selectedGun.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void playerGunsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerGunsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerGunsListBox.SelectedIndex;
                GunGeneration.Gun selectedGun;

                if (selectedIndex < player.Inventory.Count)
                {
                    selectedGun = player.Inventory[selectedIndex];
                }
                else
                {
                    selectedIndex -= player.Inventory.Count;
                    selectedGun = vault.Guns[selectedIndex];
                }

                playerGunDetailsTextBox.Text = selectedGun.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void playerHealingItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerHealingItemsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerHealingItemsListBox.SelectedIndex;
                HealingItem selectedItem;

                if (selectedIndex < player.HealingItems.Count)
                {
                    selectedItem = player.HealingItems[selectedIndex];
                }
                else
                {
                    selectedIndex -= player.HealingItems.Count;
                    selectedItem = vault.HealingItems[selectedIndex];
                }

                MessageBox.Show(selectedItem.ToString());
            }
        }

        private void armorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (armorsListBox.SelectedIndex >= 0)
            {
                var selectedArmor = armorsForSale[armorsListBox.SelectedIndex];
                armorDetailsTextBox.Text = selectedArmor.ToString().Replace("\n", Environment.NewLine);
            }
        }

        public void playerArmorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerArmorsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerArmorsListBox.SelectedIndex;
                ArmorGeneration.Armor selectedArmor;

                if (selectedIndex < player.Armors.Count)
                {
                    selectedArmor = player.Armors[selectedIndex];
                }
                else
                {
                    selectedIndex -= player.Armors.Count;
                    selectedArmor = vault.Armors[selectedIndex];
                }

                playerArmorDetailsTextBox.Text = selectedArmor.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void BuyGunButton_Click(object sender, EventArgs e)
        {
            if (gunsListBox.SelectedIndex >= 0)
            {
                var selectedGun = gunsForSale[gunsListBox.SelectedIndex];
                if (player.Wallet >= selectedGun.Price)
                {
                    player.Wallet -= selectedGun.Price;
                    player.Inventory.Add(selectedGun);
                    gunsForSale.RemoveAt(gunsListBox.SelectedIndex);
                    LoadGunsForSale();
                    LoadPlayerGuns();
                    UpdateWalletLabel();
                    MessageBox.Show("Gun purchased successfully!");
                }
                else
                {
                    MessageBox.Show("Not enough coins!");
                }
            }
        }

        private void BuySmallHealingItemButton_Click(object sender, EventArgs e)
        {
            var smallHealingItem = HealingItemGenerator.GenerateHealingItem("Poor");
            BuyHealingItem(smallHealingItem);
        }

        private void BuyMediumHealingItemButton_Click(object sender, EventArgs e)
        {
            var mediumHealingItem = HealingItemGenerator.GenerateHealingItem("Standard");
            BuyHealingItem(mediumHealingItem);
        }

        private void BuyLargeHealingItemButton_Click(object sender, EventArgs e)
        {
            var largeHealingItem = HealingItemGenerator.GenerateHealingItem("Superior");
            BuyHealingItem(largeHealingItem);
        }

        private void BuyFirstRateHealingItemButton_Click(object sender, EventArgs e)
        {
            var firstRateHealingItem = HealingItemGenerator.GenerateHealingItem("First-rate");
            BuyHealingItem(firstRateHealingItem);
        }

        private void BuyHealingItem(HealingItem item)
        {
            if (player.Wallet >= item.Price)
            {
                player.Wallet -= item.Price;
                player.HealingItems.Add(item);
                UpdateWalletLabel();
                MessageBox.Show($"You bought a {item.Name}!");
                LoadPlayerHealingItems(); // Update the player's healing items list
            }
            else
            {
                MessageBox.Show("Not enough coins to buy this item.");
            }
        }

        private void SellGunButton_Click(object sender, EventArgs e)
        {
            if (playerGunsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerGunsListBox.SelectedIndex;
                GunGeneration.Gun selectedGun;

                if (selectedIndex < player.Inventory.Count)
                {
                    selectedGun = player.Inventory[selectedIndex];
                    player.Inventory.RemoveAt(selectedIndex);
                }
                else
                {
                    selectedIndex -= player.Inventory.Count;
                    selectedGun = vault.Guns[selectedIndex];
                    vault.RemoveGun(selectedGun);
                }

                player.Wallet += selectedGun.Price / 2;
                LoadPlayerGuns(); // Update the player's inventory and vault list
                UpdateWalletLabel();
                MessageBox.Show("Gun sold successfully!");
            }
        }

        public void BuyArmorButton_Click(object sender, EventArgs e)
        {
            if (armorsListBox.SelectedIndex >= 0)
            {
                var selectedArmor = armorsForSale[armorsListBox.SelectedIndex];
                if (player.Wallet >= selectedArmor.Price)
                {
                    player.Wallet -= selectedArmor.Price;
                    player.Armors.Add(selectedArmor);
                    armorsForSale.RemoveAt(armorsListBox.SelectedIndex);
                    LoadArmorsForSale();
                    LoadPlayerArmors();
                    UpdateWalletLabel();
                    MessageBox.Show("Armor purchased successfully!");
                }
                else
                {
                    MessageBox.Show("Not enough coins!");
                }
            }
        }

        public void SellArmorButton_Click(object sender, EventArgs e)
        {
            if (playerArmorsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerArmorsListBox.SelectedIndex;
                ArmorGeneration.Armor selectedArmor;

                if (selectedIndex < player.Armors.Count)
                {
                    selectedArmor = player.Armors[selectedIndex];
                    player.Armors.RemoveAt(selectedIndex);
                }
                else
                {
                    selectedIndex -= player.Armors.Count;
                    selectedArmor = vault.Armors[selectedIndex];
                    vault.RemoveArmor(selectedArmor);
                }

                player.Wallet += selectedArmor.Price / 2;
                LoadPlayerArmors(); // Update the player's inventory and vault list
                UpdateWalletLabel();
                MessageBox.Show("Armor sold successfully!");
            }
        }
    }
}

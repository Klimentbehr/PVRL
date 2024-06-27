using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;

namespace PVRL
{
    public partial class StoreForm : Form
    {
        private List<GunGeneration.Gun> lowTierGunsForSale;
        private List<GunGeneration.Gun> midTierGunsForSale;
        private List<GunGeneration.Gun> highTierGunsForSale;
        private List<ArmorGeneration.Armor> armorsForSale;
        private List<RepairKit> repairKitsForSale;
        private List<Character> characters;
        private Character selectedCharacter;
        private Vault vault;
        private GunGeneration gunGenerator;

        public StoreForm(List<Character> characters, Character selectedCharacter, Vault vault)
        {
            InitializeComponent();
            this.characters = characters;
            this.selectedCharacter = selectedCharacter;
            this.vault = vault;
            this.gunGenerator = new GunGeneration();
            characterComboBox.SelectedIndexChanged += CharacterComboBox_SelectedIndexChanged;
            PopulateCharacterComboBox();
        }

        private void PopulateCharacterComboBox()
        {
            characterComboBox.Items.Clear();
            foreach (var character in characters)
            {
                characterComboBox.Items.Add(character.Name);
            }
            if (characters.Count > 0)
            {
                characterComboBox.SelectedIndex = 0; // Select the first character by default
            }
        }

        private void CharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCharacterName = characterComboBox.SelectedItem.ToString();
            selectedCharacter = characters.FirstOrDefault(c => c.Name == selectedCharacterName);
            LoadStoreData();
        }

        private void LoadStoreData()
        {
            LoadGunsForSale();
            LoadArmorsForSale();
            // LoadRepairKitsForSale(); // Uncomment if repair kits are implemented
            LoadPlayerGuns();
            LoadPlayerHealingItems();
            LoadPlayerArmors();
            // LoadPlayerRepairKits(); // Uncomment if repair kits are implemented
            UpdateWalletLabel();
        }

        private void UpdateWalletLabel()
        {
            walletLabel.Text = $"Wallet: {selectedCharacter.Wallet} credits";
        }

        private void LoadGunsForSale()
        {
            try
            {
                lowTierGunsForSale = LoadGunsFromFile(DifficultyLevel.Easy);
                midTierGunsForSale = LoadGunsFromFile(DifficultyLevel.Normal);
                highTierGunsForSale = LoadGunsFromFile(DifficultyLevel.Hard);

                // Display only a limited number of guns from each tier
                var displayedLowTierGuns = lowTierGunsForSale.OrderBy(x => Guid.NewGuid()).Take(5).ToList();
                var displayedMidTierGuns = midTierGunsForSale.OrderBy(x => Guid.NewGuid()).Take(5).ToList();
                var displayedHighTierGuns = highTierGunsForSale.OrderBy(x => Guid.NewGuid()).Take(5).ToList();

                gunsListBox.Items.Clear();
                gunsListBox.Items.Add("Low Tier Guns:");
                foreach (var gun in displayedLowTierGuns)
                {
                    gunsListBox.Items.Add($"{gun.Name} - Price: {GetBuyingPrice(gun.Price):F2}");
                }

                gunsListBox.Items.Add("Mid Tier Guns:");
                foreach (var gun in displayedMidTierGuns)
                {
                    gunsListBox.Items.Add($"{gun.Name} - Price: {GetBuyingPrice(gun.Price):F2}");
                }

                gunsListBox.Items.Add("High Tier Guns:");
                foreach (var gun in displayedHighTierGuns)
                {
                    gunsListBox.Items.Add($"{gun.Name} - Price: {GetBuyingPrice(gun.Price):F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guns for sale: {ex.Message}");
            }
        }

        private List<GunGeneration.Gun> LoadGunsFromFile(DifficultyLevel difficulty)
        {
            List<GunGeneration.Gun> guns = new List<GunGeneration.Gun>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GeneratedFiles", $"Guns_{difficulty}.txt");
                if (!File.Exists(filePath))
                {
                    // Generate and save 15 random guns using the existing gun generation system
                    guns = GenerateRandomGuns(15, difficulty);
                    SaveGunsToFile(guns, filePath);
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guns from file: {ex.Message}");
            }
            return guns;
        }

        private List<GunGeneration.Gun> GenerateRandomGuns(int numberOfGuns, DifficultyLevel difficulty)
        {
            List<GunGeneration.Gun> guns = new List<GunGeneration.Gun>();
            for (int i = 0; i < numberOfGuns; i++)
            {
                var gun = gunGenerator.GenerateRandomGun(difficulty);
                guns.Add(gun);
            }
            return guns;
        }

        private void SaveGunsToFile(List<GunGeneration.Gun> guns, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllLines(filePath, guns.Select(gun => JsonConvert.SerializeObject(gun)).ToArray());
        }

        private void LoadArmorsForSale()
        {
            try
            {
                armorsForSale = ArmorGeneration.GenerateRandomArmors(10); // Generate 10 random armor items

                armorsListBox.Items.Clear();
                foreach (var armor in armorsForSale)
                {
                    armorsListBox.Items.Add($"{armor.Name} - Price: {GetBuyingPrice(armor.Price):F2}");
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
            foreach (var gun in selectedCharacter.Inventory)
            {
                playerGunsListBox.Items.Add($"{gun.Name} - Sell Price: {GetSellingPrice(gun.Price):F2}");
            }

            // Load guns from the vault as well
            foreach (var gun in vault.Guns)
            {
                playerGunsListBox.Items.Add($"{gun.Name} - Sell Price: {GetSellingPrice(gun.Price):F2}");
            }
        }

        private void LoadPlayerHealingItems()
        {
            playerHealingItemsListBox.Items.Clear();
            foreach (var item in selectedCharacter.HealingItems)
            {
                playerHealingItemsListBox.Items.Add($"{item.Name}");
            }

            // Load healing items from the vault as well
            foreach (var item in vault.HealingItems)
            {
                playerHealingItemsListBox.Items.Add($"{item.Name}");
            }
        }

        private void LoadPlayerArmors()
        {
            playerArmorsListBox.Items.Clear();
            foreach (var armor in selectedCharacter.Armors)
            {
                playerArmorsListBox.Items.Add($"{armor.Name} - Sell Price: {GetSellingPrice(armor.Price):F2}");
            }

            // Load armors from the vault as well
            foreach (var armor in vault.Armors)
            {
                playerArmorsListBox.Items.Add($"{armor.Name} - Sell Price: {GetSellingPrice(armor.Price):F2}");
            }
        }

        private void gunsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = gunsListBox.SelectedIndex;
            if (selectedIndex < 0) return;

            // Skip the "Low Tier Guns:", "Mid Tier Guns:", "High Tier Guns:" labels
            if (selectedIndex == 0 || selectedIndex == 6 || selectedIndex == 12)
            {
                gunDetailsTextBox.Clear();
                return;
            }

            GunGeneration.Gun selectedGun = null;
            if (selectedIndex > 0 && selectedIndex < 6)
            {
                selectedGun = lowTierGunsForSale[selectedIndex - 1];
            }
            else if (selectedIndex > 6 && selectedIndex < 12)
            {
                selectedGun = midTierGunsForSale[selectedIndex - 7];
            }
            else if (selectedIndex > 12)
            {
                selectedGun = highTierGunsForSale[selectedIndex - 13];
            }

            if (selectedGun != null)
            {
                gunDetailsTextBox.Text = selectedGun.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void playerGunsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerGunsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = playerGunsListBox.SelectedIndex;
                GunGeneration.Gun selectedGun;

                if (selectedIndex < selectedCharacter.Inventory.Count)
                {
                    selectedGun = selectedCharacter.Inventory[selectedIndex];
                }
                else
                {
                    selectedIndex -= selectedCharacter.Inventory.Count;
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

                if (selectedIndex < selectedCharacter.HealingItems.Count)
                {
                    selectedItem = selectedCharacter.HealingItems[selectedIndex];
                }
                else
                {
                    selectedIndex -= selectedCharacter.HealingItems.Count;
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

                if (selectedIndex < selectedCharacter.Armors.Count)
                {
                    selectedArmor = selectedCharacter.Armors[selectedIndex];
                }
                else
                {
                    selectedIndex -= selectedCharacter.Armors.Count;
                    selectedArmor = vault.Armors[selectedIndex];
                }

                playerArmorDetailsTextBox.Text = selectedArmor.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void BuyGunButton_Click(object sender, EventArgs e)
        {
            if (gunsListBox.SelectedIndices.Count == 0) return;

            double totalCost = 0;
            List<GunGeneration.Gun> selectedGuns = new List<GunGeneration.Gun>();

            foreach (int index in gunsListBox.SelectedIndices.Cast<int>().ToList())
            {
                int selectedIndex = index;
                if (selectedIndex == 0 || selectedIndex == 6 || selectedIndex == 12) continue;

                GunGeneration.Gun selectedGun = null;
                if (selectedIndex > 0 && selectedIndex < 6)
                {
                    selectedGun = lowTierGunsForSale[selectedIndex - 1];
                }
                else if (selectedIndex > 6 && selectedIndex < 12)
                {
                    selectedGun = midTierGunsForSale[selectedIndex - 7];
                }
                else if (selectedIndex > 12)
                {
                    selectedGun = highTierGunsForSale[selectedIndex - 13];
                }

                if (selectedGun != null)
                {
                    totalCost += GetBuyingPrice(selectedGun.Price);
                    selectedGuns.Add(selectedGun);
                }
            }

            if (selectedCharacter.Wallet >= (int)totalCost)
            {
                selectedCharacter.Wallet -= (int)totalCost;
                selectedCharacter.Inventory.AddRange(selectedGuns);

                List<GunGeneration.Gun> gunsToRemove = new List<GunGeneration.Gun>();
                foreach (var gun in selectedGuns)
                {
                    if (lowTierGunsForSale.Contains(gun))
                    {
                        gunsToRemove.Add(gun);
                    }
                    else if (midTierGunsForSale.Contains(gun))
                    {
                        gunsToRemove.Add(gun);
                    }
                    else if (highTierGunsForSale.Contains(gun))
                    {
                        gunsToRemove.Add(gun);
                    }
                }
                foreach (var gun in gunsToRemove)
                {
                    if (lowTierGunsForSale.Contains(gun))
                    {
                        lowTierGunsForSale.Remove(gun);
                    }
                    else if (midTierGunsForSale.Contains(gun))
                    {
                        midTierGunsForSale.Remove(gun);
                    }
                    else if (highTierGunsForSale.Contains(gun))
                    {
                        highTierGunsForSale.Remove(gun);
                    }
                }

                LoadGunsForSale();
                LoadPlayerGuns();
                UpdateWalletLabel();
                MessageBox.Show("Guns purchased successfully!");
            }
            else
            {
                MessageBox.Show("Not enough credits!");
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
            double finalPrice = GetBuyingPrice(item.Price);
            if (selectedCharacter.Wallet >= (int)finalPrice)
            {
                selectedCharacter.Wallet -= (int)finalPrice;
                selectedCharacter.HealingItems.Add(item);
                UpdateWalletLabel();
                MessageBox.Show($"You bought a {item.Name}!");
                LoadPlayerHealingItems(); // Update the player's healing items list
            }
            else
            {
                MessageBox.Show("Not enough credits to buy this item.");
            }
        }

        private void SellGunButton_Click(object sender, EventArgs e)
        {
            if (playerGunsListBox.SelectedIndices.Count == 0) return;

            double totalSellPrice = 0;
            List<GunGeneration.Gun> selectedGuns = new List<GunGeneration.Gun>();

            // Collect the indices in a list to avoid modifying the collection while iterating
            var selectedIndices = playerGunsListBox.SelectedIndices.Cast<int>().ToList();

            // Sort the indices in descending order to remove items without affecting the subsequent indices
            selectedIndices.Sort((a, b) => b.CompareTo(a));

            foreach (int index in selectedIndices)
            {
                int selectedIndex = index;
                GunGeneration.Gun selectedGun;

                if (selectedIndex < selectedCharacter.Inventory.Count)
                {
                    selectedGun = selectedCharacter.Inventory[selectedIndex];
                    selectedCharacter.Inventory.RemoveAt(selectedIndex);
                }
                else
                {
                    selectedIndex -= selectedCharacter.Inventory.Count;
                    if (selectedIndex < vault.Guns.Count)
                    {
                        selectedGun = vault.Guns[selectedIndex];
                        vault.RemoveGun(selectedGun);
                    }
                    else
                    {
                        continue; // Skip if index is out of range
                    }
                }

                totalSellPrice += GetSellingPrice(selectedGun.Price);
                selectedGuns.Add(selectedGun);
            }

            selectedCharacter.Wallet += (int)totalSellPrice;
            LoadPlayerGuns(); // Update the player's inventory and vault list
            UpdateWalletLabel();
            MessageBox.Show("Guns sold successfully!");
        }

        public void BuyArmorButton_Click(object sender, EventArgs e)
        {
            if (armorsListBox.SelectedIndices.Count == 0) return;

            double totalCost = 0;
            List<ArmorGeneration.Armor> selectedArmors = new List<ArmorGeneration.Armor>();

            foreach (int index in armorsListBox.SelectedIndices.Cast<int>().ToList())
            {
                int selectedIndex = index;
                var selectedArmor = armorsForSale[selectedIndex];
                totalCost += GetBuyingPrice(selectedArmor.Price);
                selectedArmors.Add(selectedArmor);
            }

            if (selectedCharacter.Wallet >= (int)totalCost)
            {
                selectedCharacter.Wallet -= (int)totalCost;
                selectedCharacter.Armors.AddRange(selectedArmors);

                List<ArmorGeneration.Armor> armorsToRemove = new List<ArmorGeneration.Armor>();
                foreach (var armor in selectedArmors)
                {
                    armorsToRemove.Add(armor);
                }
                foreach (var armor in armorsToRemove)
                {
                    armorsForSale.Remove(armor);
                }

                LoadArmorsForSale();
                LoadPlayerArmors();
                UpdateWalletLabel();
                MessageBox.Show("Armors purchased successfully!");
            }
            else
            {
                MessageBox.Show("Not enough credits!");
            }
        }

        public void SellArmorButton_Click(object sender, EventArgs e)
        {
            if (playerArmorsListBox.SelectedIndices.Count == 0) return;

            double totalSellPrice = 0;
            List<ArmorGeneration.Armor> selectedArmors = new List<ArmorGeneration.Armor>();

            // Collect the indices in a list to avoid modifying the collection while iterating
            var selectedIndices = playerArmorsListBox.SelectedIndices.Cast<int>().ToList();

            // Sort the indices in descending order to remove items without affecting the subsequent indices
            selectedIndices.Sort((a, b) => b.CompareTo(a));

            foreach (int index in selectedIndices)
            {
                int selectedIndex = index;
                ArmorGeneration.Armor selectedArmor;

                if (selectedIndex < selectedCharacter.Armors.Count)
                {
                    selectedArmor = selectedCharacter.Armors[selectedIndex];
                    selectedCharacter.Armors.RemoveAt(selectedIndex);
                }
                else
                {
                    selectedIndex -= selectedCharacter.Armors.Count;
                    if (selectedIndex < vault.Armors.Count)
                    {
                        selectedArmor = vault.Armors[selectedIndex];
                        vault.RemoveArmor(selectedArmor);
                    }
                    else
                    {
                        continue; // Skip if index is out of range
                    }
                }

                totalSellPrice += GetSellingPrice(selectedArmor.Price);
                selectedArmors.Add(selectedArmor);
            }

            selectedCharacter.Wallet += (int)totalSellPrice;
            LoadPlayerArmors(); // Update the player's inventory and vault list
            UpdateWalletLabel();
            MessageBox.Show("Armors sold successfully!");
        }

        private double GetCharismaModifier()
        {
            return 1 + (selectedCharacter.Charisma * 0.0025);
        }

        private double GetBuyingPrice(double basePrice)
        {
            double modifier = GetCharismaModifier();
            return basePrice / modifier;
        }

        private double GetSellingPrice(double basePrice)
        {
            double modifier = GetCharismaModifier();
            return basePrice * modifier * 0.75; // Always sell for less than the buying price
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



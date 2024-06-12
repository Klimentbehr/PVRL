using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Main;
using Newtonsoft.Json;

namespace PVRL
{
    public partial class MainForm : Form
    {
        private List<Character> characters;
        public Vault vault;
        private const string charactersDirectory = "Characters";

        public MainForm()
        {
            InitializeComponent();
            characters = new List<Character>();
            vault = new Vault();
            LoadCharacters();
            LoadPlayerInventory(); // Load player's inventory into the vault
        }

        private void LoadCharacters()
        {
            try
            {
                string[] characterFiles = Directory.GetFiles(charactersDirectory, "*.txt");
                foreach (var file in characterFiles)
                {
                    string json = File.ReadAllText(file);
                    var character = JsonConvert.DeserializeObject<Character>(json);
                    if (character != null)
                    {
                        characters.Add(character);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading characters: {ex.Message}");
            }
        }

        private void LoadPlayerInventory()
        {
            foreach (var character in characters)
            {
                if (character.Inventory != null)
                {
                    foreach (var gun in character.Inventory)
                    {
                        vault.AddGun(gun);
                    }
                }
            }
        }

        private void CharacterCreationButton_Click(object sender, EventArgs e)
        {
            var characterCreationForm = new CharacterCreationForm(vault, characters);
            characterCreationForm.ShowDialog();
            characters.Clear(); // Clear current characters list
            LoadCharacters(); // Reload characters after creation
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(characters, vault);
            inventoryForm.ShowDialog();
            SaveAllCharacters(); // Save all characters after inventory management
        }

        private void PveButton_Click(object sender, EventArgs e)
        {
            CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
            if (selectionForm.ShowDialog() == DialogResult.OK)
            {
                Character selectedCharacter = selectionForm.SelectedCharacter;
                selectedCharacter.Health = 100; // Fully heal the player

                // Show difficulty selection dialog
                DifficultySelectionForm difficultySelectionForm = new DifficultySelectionForm();
                if (difficultySelectionForm.ShowDialog() == DialogResult.OK)
                {
                    Main.DifficultyLevel difficulty = difficultySelectionForm.SelectedDifficulty;

                    bool continueCombat = true;

                    // Continue PvE combat until the player dies, closes the form, or loses the fight
                    while (continueCombat && selectedCharacter.Health > 0)
                    {
                        using (CombatForm combatForm = new CombatForm(selectedCharacter, difficulty, vault))
                        {
                            combatForm.ShowDialog();

                            if (!combatForm.PlayerWon || combatForm.DialogResult == DialogResult.Cancel)
                            {
                                continueCombat = false; // Exit the loop if the player lost or closed the form
                            }
                            else
                            {
                                int experienceGained = CalculateExperienceGained(selectedCharacter, difficulty);
                                selectedCharacter.GainExperience(experienceGained);
                                SaveCharacter(selectedCharacter); // Save character after gaining experience
                            }
                        }
                    }

                    // Inform the player if they were defeated
                    if (selectedCharacter.Health <= 0)
                    {
                        MessageBox.Show("You have been defeated in PvE combat.");
                    }
                }
            }
        }

        private int CalculateExperienceGained(Character enemy, Main.DifficultyLevel difficulty)
        {
            Random random = new Random();

            switch (difficulty)
            {
                case Main.DifficultyLevel.Easy:
                    return random.Next(10, 41); // Experience between 20 and 40 for easy enemies
                case Main.DifficultyLevel.Normal:
                    return random.Next(42, 60); // Experience for normal enemies
                case Main.DifficultyLevel.Hard:
                    return random.Next(61, 80); // Experience for hard enemies
                default:
                    return 0;
            }
        }

        private void SkillsButton_Click(object sender, EventArgs e)
        {
            CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
            if (selectionForm.ShowDialog() == DialogResult.OK)
            {
                Character selectedCharacter = selectionForm.SelectedCharacter;
                SkillForm skillForm = new SkillForm(selectedCharacter);
                skillForm.ShowDialog();
                SaveCharacter(selectedCharacter); // Save character after skill update
            }
        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            CraftingForm craftingForm = new CraftingForm(characters, vault);
            craftingForm.ShowDialog();
            SaveAllCharacters(); // Save all characters after crafting
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
            if (selectionForm.ShowDialog() == DialogResult.OK)
            {
                Character selectedCharacter = selectionForm.SelectedCharacter;
                StoreForm storeForm = new StoreForm(selectedCharacter, vault);
                storeForm.ShowDialog();
                SaveAllCharacters(); // Save all characters after store operations
            }
        }

        private void SaveAllCharacters()
        {
            foreach (var character in characters)
            {
                SaveCharacter(character);
            }
        }

        private void SaveCharacter(Character character)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonConvert.SerializeObject(character, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving character {character.Name}: {ex.Message}");
            }
        }

        private void generateGunsButton_Click(object sender, EventArgs e)
        {

        }
    }
}

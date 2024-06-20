using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;
using WMPLib; // Add this namespace for Windows Media Player

namespace PVRL
{
    public partial class MainForm : Form
    {
        private List<Character> characters;
        public Vault vault;
        private const string charactersDirectory = "Characters";
        private WindowsMediaPlayer backgroundPlayer; // Add this field for background music

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            characters = new List<Character>();
            vault = new Vault();

            // Initialize and play background music
            InitializeBackgroundMusic();

            // Load data asynchronously
            LoadDataAsync();
        }

        private void InitializeBackgroundMusic()
        {
            backgroundPlayer = new WindowsMediaPlayer();
            backgroundPlayer.URL = "E:\\Hitfromthebeast\\Hitfromthebeast.mp3"; // Replace with the path to your music file
            backgroundPlayer.settings.setMode("loop", true); // Loop the music
            backgroundPlayer.settings.volume = 30; // Set volume (0 to 100)
            backgroundPlayer.controls.play();
        }

        private async void LoadDataAsync()
        {
            await LoadCharactersAsync();
            LoadPlayerInventory();
            InitializeManageCharacterControl(); // Initialize ManageCharacterControl with data
            CenterControls();
        }

        private async Task LoadCharactersAsync()
        {
            try
            {
                string[] characterFiles = Directory.GetFiles(charactersDirectory, "*.txt");
                var tasks = new List<Task<Character>>();

                foreach (var file in characterFiles)
                {
                    tasks.Add(Task.Run(() => LoadCharacter(file)));
                }

                var results = await Task.WhenAll(tasks);

                foreach (var character in results)
                {
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

        private Character LoadCharacter(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Character>(json);
            }
            catch
            {
                return null;
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

        private void InitializeManageCharacterControl()
        {
            if (characters.Count > 0)
            {
                manageCharacterControl.SetCharacterAndVault(characters[0], vault);
            }
        }

        private void CharacterCreationButton_Click(object sender, EventArgs e)
        {
            var characterCreationForm = new CharacterCreationForm(vault, characters);
            characterCreationForm.ShowDialog();
            characters.Clear(); // Clear current characters list
            LoadDataAsync(); // Reload characters after creation
        }

        private void ManageCharacterButton_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = manageCharacterTabPage;
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
                    DifficultyLevel difficulty = difficultySelectionForm.SelectedDifficulty;

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

        private int CalculateExperienceGained(Character enemy, DifficultyLevel difficulty)
        {
            Random random = new Random();

            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    return random.Next(10, 41); // Experience between 10 and 40 for easy enemies
                case DifficultyLevel.Normal:
                    return random.Next(42, 60); // Experience for normal enemies
                case DifficultyLevel.Hard:
                    return random.Next(61, 80); // Experience for hard enemies
                default:
                    return 0;
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int buttonWidth = (int)(this.ClientSize.Width * 0.3); // 30% of the form's width
            int buttonHeight = (int)(this.ClientSize.Height * 0.1); // 10% of the form's height
            int spacing = (int)(buttonHeight * 0.25); // Space between buttons, 25% of button height

            characterCreationButton.Size = new Size(buttonWidth, buttonHeight);
            manageCharacterButton.Size = new Size(buttonWidth, buttonHeight);
            pveButton.Size = new Size(buttonWidth, buttonHeight);
            exitButton.Size = new Size(buttonWidth, buttonHeight);

            characterCreationButton.Location = new Point(centerX - buttonWidth / 2, centerY - 2 * (buttonHeight + spacing));
            manageCharacterButton.Location = new Point(centerX - buttonWidth / 2, centerY - (buttonHeight + spacing / 2));
            pveButton.Location = new Point(centerX - buttonWidth / 2, centerY + spacing / 2);
            exitButton.Location = new Point(centerX - buttonWidth / 2, centerY + buttonHeight + (int)(1.5 * spacing));

            int buttonFontSize = (int)(buttonHeight * 0.25); // Set font size to 25% of button height
            characterCreationButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            manageCharacterButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            pveButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);

            int labelFontSize = (int)(this.ClientSize.Width * 0.035); // Set font size based on window width
            label1.Font = new Font("Segoe UI", labelFontSize, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(centerX - label1.Width / 2, centerY - 3 * (buttonHeight + spacing) - label1.Height);
        }


        public void ReturnToHome()
        {
            mainTabControl.SelectedTab = homeTabPage;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCharacterControl_InventoryButtonClicked(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                InventoryForm inventoryForm = new InventoryForm(characters, vault);
                inventoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No characters available to manage inventory.");
            }
        }

        private void ManageCharacterControl_SkillsButtonClicked(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                SkillForm skillsForm = new SkillForm(characters[0]);
                skillsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No characters available to manage skills.");
            }
        }

        private void ManageCharacterControl_CraftingButtonClicked(object sender, EventArgs e)
        {
            CraftingForm craftingForm = new CraftingForm(characters, vault);
            craftingForm.ShowDialog();
        }

        private void ManageCharacterControl_StoreButtonClicked(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                StoreForm storeForm = new StoreForm(characters[0], vault);
                storeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No characters available to manage store.");
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homeTabPage_Click(object sender, EventArgs e)
        {
        }
    }
}
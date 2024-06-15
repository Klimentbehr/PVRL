using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;

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
            DoubleBuffered = true;
            characters = new List<Character>();
            vault = new Vault();

            // Set to fullscreen on launch
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Set background image
            this.BackgroundImage = Image.FromFile("C:\\Users\\emoco\\Downloads\\A_geometric_low-poly_background_for_PVRL_compatible_3k.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Handle resize event
            this.Resize += MainForm_Resize;

            // Load data asynchronously
            LoadDataAsync();
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

            int buttonWidth = (int)(this.ClientSize.Width * 0.3); // Increase button width
            int buttonHeight = (int)(this.ClientSize.Height * 0.1); // Increase button height
            int spacing = (int)(buttonHeight * 0.1); // Space between buttons

            characterCreationButton.Size = new Size(buttonWidth, buttonHeight);
            manageCharacterButton.Size = new Size(buttonWidth, buttonHeight);
            pveButton.Size = new Size(buttonWidth, buttonHeight);
            exitButton.Size = new Size(buttonWidth, buttonHeight);

            characterCreationButton.Location = new Point(centerX - buttonWidth / 2, centerY - 2 * buttonHeight - 2 * spacing);
            manageCharacterButton.Location = new Point(centerX - buttonWidth / 2, centerY - buttonHeight / 2 - spacing);
            pveButton.Location = new Point(centerX - buttonWidth / 2, centerY + buttonHeight + spacing);
            exitButton.Location = new Point(centerX - buttonWidth / 2, centerY + 2 * buttonHeight + 2 * spacing);

            int buttonFontSize = (int)(buttonHeight * 0.25); // Set font size to 25% of button height
            characterCreationButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            manageCharacterButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            pveButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);

            int labelFontSize = (int)(this.ClientSize.Width * 0.035); // Set font size based on window width
            label1.Font = new Font("Segoe UI", labelFontSize, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(centerX - label1.Width / 2, centerY - 3 * buttonHeight - 3 * spacing - label1.Height);
        }

        public void ReturnToHome()
        {
            mainTabControl.SelectedTab = homeTabPage;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;
using WMPLib;

namespace PVRL
{
    public partial class MainForm : Form
    {
        private List<Character> characters;
        public Vault vault;
        private const string charactersDirectory = "Characters";
        private WindowsMediaPlayer backgroundPlayer;
        private BackgroundWorker backgroundWorker;
        private BufferedGraphicsContext bufferedGraphicsContext;
        private BufferedGraphics bufferedGraphics;

        private Button inventoryButton;
        private Button skillsButton;
        private Button craftingButton;
        private Button storeButton;
        private Button returnHomeButton;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // Enable double buffering for the form
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();

            bufferedGraphicsContext = BufferedGraphicsManager.Current;
            bufferedGraphicsContext.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            bufferedGraphics = bufferedGraphicsContext.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height));

            characters = new List<Character>();
            vault = new Vault();

            InitializeBackgroundWorker();
            InitializeManageCharacterControls();

            LoadDataAsync();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            bufferedGraphics.Render(e.Graphics);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do nothing to prevent flickering
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void LoadDataAsync()
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private async void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            await LoadCharactersAsync();
            LoadPlayerInventory();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                InitializeManageCharacterControl();
                CenterControls();
                this.Invalidate(); // Redraw the form
            }));
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

                characters.Clear();
                characters.AddRange(results);
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

        private void InitializeManageCharacterControls()
        {
            inventoryButton = new Button { Text = "Inventory" };
            skillsButton = new Button { Text = "Skills" };
            craftingButton = new Button { Text = "Crafting" };
            storeButton = new Button { Text = "Store" };
            returnHomeButton = new Button { Text = "Return Home" };
            characterCreationButton = new Button { Text = "Create Character" };
            manageCharacterButton = new Button { Text = "Manage Character" };
            playButton = new Button { Text = "Play" }; // Changed from pveButton to playButton
            exitButton = new Button { Text = "Exit" };
            label1 = new Label { Text = "Main Menu" };

            inventoryButton.Click += InventoryButton_Click;
            skillsButton.Click += SkillsButton_Click;
            craftingButton.Click += CraftingButton_Click;
            storeButton.Click += StoreButton_Click;
            returnHomeButton.Click += ReturnHomeButton_Click;
            characterCreationButton.Click += CharacterCreationButton_Click;
            manageCharacterButton.Click += ManageCharacterButton_Click;
            playButton.Click += PlayButton_Click; // Changed from pveButton to playButton
            exitButton.Click += ExitButton_Click;

            SetControlStyles(inventoryButton);
            SetControlStyles(skillsButton);
            SetControlStyles(craftingButton);
            SetControlStyles(storeButton);
            SetControlStyles(returnHomeButton);
            SetControlStyles(characterCreationButton);
            SetControlStyles(manageCharacterButton);
            SetControlStyles(playButton); // Changed from pveButton to playButton
            SetControlStyles(exitButton);

            Controls.Add(inventoryButton);
            Controls.Add(skillsButton);
            Controls.Add(craftingButton);
            Controls.Add(storeButton);
            Controls.Add(returnHomeButton);
            Controls.Add(characterCreationButton);
            Controls.Add(manageCharacterButton);
            Controls.Add(playButton); // Changed from pveButton to playButton
            Controls.Add(exitButton);
            Controls.Add(label1);

            Resize += MainForm_Resize;
            CenterControls();
        }

        private void SetControlStyles(Control control)
        {
            control.GetType().InvokeMember("SetStyle",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod,
                null, control, new object[] { ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true });

            control.GetType().InvokeMember("UpdateStyles",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod,
                null, control, null);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
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

        private void SkillsButton_Click(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    Character selectedCharacter = selectionForm.SelectedCharacter;
                    SkillForm skillsForm = new SkillForm(characters, selectedCharacter);
                    skillsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No characters available to manage skills.");
            }
        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            CraftingForm craftingForm = new CraftingForm(characters, vault);
            craftingForm.ShowDialog();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    Character selectedCharacter = selectionForm.SelectedCharacter;
                    StoreForm storeForm = new StoreForm(characters, selectedCharacter, vault);
                    storeForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No characters available to manage store.");
            }
        }

        private void ReturnHomeButton_Click(object sender, EventArgs e)
        {
            ReturnToHome();
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

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (characters.Count > 0)
            {
                CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    Character selectedCharacter = selectionForm.SelectedCharacter;
                    var factionHomeScreen = new FactionHomeScreen(selectedCharacter, vault);
                    factionHomeScreen.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No characters available to play.");
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
            this.SuspendLayout();
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int buttonWidth = (int)(this.ClientSize.Width * 0.3); // 30% of the form's width
            int buttonHeight = (int)(this.ClientSize.Height * 0.1); // 10% of the form's height
            int spacing = (int)(buttonHeight * 0.25); // Space between buttons, 25% of button height

            characterCreationButton.Size = new Size(buttonWidth, buttonHeight);
            manageCharacterButton.Size = new Size(buttonWidth, buttonHeight);
            playButton.Size = new Size(buttonWidth, buttonHeight); // Changed from pveButton to playButton
            exitButton.Size = new Size(buttonWidth, buttonHeight);

            characterCreationButton.Location = new Point(centerX - buttonWidth / 2, centerY - 2 * (buttonHeight + spacing));
            manageCharacterButton.Location = new Point(centerX - buttonWidth / 2, centerY - (buttonHeight + spacing / 2));
            playButton.Location = new Point(centerX - buttonWidth / 2, centerY + spacing / 2); // Changed from pveButton to playButton
            exitButton.Location = new Point(centerX - buttonWidth / 2, centerY + buttonHeight + (int)(1.5 * spacing));

            int buttonFontSize = (int)(buttonHeight * 0.25); // Set font size to 25% of button height
            characterCreationButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            manageCharacterButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            playButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point); // Changed from pveButton to playButton
            exitButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);

            int labelFontSize = (int)(this.ClientSize.Width * 0.035); // Set font size based on window width
            label1.Font = new Font("Segoe UI", labelFontSize, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(centerX - label1.Width / 2, centerY - 3 * (buttonHeight + spacing) - label1.Height);
            this.ResumeLayout(true);
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
                CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    Character selectedCharacter = selectionForm.SelectedCharacter;
                    SkillForm skillsForm = new SkillForm(characters, selectedCharacter);
                    skillsForm.ShowDialog();
                }
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
                CharacterSelectionForm selectionForm = new CharacterSelectionForm(characters);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    Character selectedCharacter = selectionForm.SelectedCharacter;
                    StoreForm storeForm = new StoreForm(characters, selectedCharacter, vault);
                    storeForm.ShowDialog();
                }
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
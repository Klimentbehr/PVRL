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
    public partial class CharacterCreationForm : Form
    {
        private Vault vault;
        private List<Character> characters;
        private GunGeneration.Gun currentGun;

        public CharacterCreationForm(Vault vault, List<Character> characters)
        {
            InitializeComponent();
            this.vault = vault;
            this.characters = characters;

            // Make the form fullscreen and adjust style
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Start loading data
            LoadFormDataAsync();
        }

        private async void LoadFormDataAsync()
        {
            await Task.Run(() => InitializeFormData());
            raceComboBox.SelectedIndex = 0; // Default to first race
            GenerateGun();
            UpdateCharacterAttributes();
        }

        private void InitializeFormData()
        {
            // Perform any data loading operations here
            // Simulating a delay for demonstration purposes
            System.Threading.Thread.Sleep(1);
        }

        private void GenerateGun()
        {
            GunGeneration gunGen = new GunGeneration();
            string selectedRace = raceComboBox.SelectedItem.ToString();
            currentGun = gunGen.GenerateStartingGun(selectedRace);
            generatedGunLabel.Text = $"Generated Gun: {currentGun}";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string selectedRace = raceComboBox.SelectedItem.ToString();
            string selectedFaction = factionComboBox.SelectedItem.ToString();
            string characterName = nameTextBox.Text.Trim();

            if (!IsValidName(characterName))
            {
                MessageBox.Show("Please enter a valid name containing only letters and no numbers.");
                return;
            }

            Character newCharacter = new Character
            {
                Name = characterName,
                Race = selectedRace,
                Age = (int)ageNumericUpDown.Value,
                Strength = int.Parse(strengthLabelValue.Text),
                Dexterity = int.Parse(dexterityLabelValue.Text),
                Intelligence = int.Parse(intelligenceLabelValue.Text),
                Wisdom = int.Parse(wisdomLabelValue.Text),
                Charisma = int.Parse(charismaLabelValue.Text),
                Health = GetInitialHealth(),
                MaxHealth = GetInitialHealth(),
                Defense = 10,
                Gun = currentGun,
                Type = Character.CharacterType.Player,
                Wallet = GetStartingCredits(selectedRace),
                SkillSeed = GenerateSeed(),
                Faction = selectedFaction
            };

            ApplyFactionBuffs(newCharacter);

            characters.Add(newCharacter);
            vault.AddGun(currentGun);

            string json = JsonConvert.SerializeObject(newCharacter, Formatting.Indented);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{newCharacter.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, json);

            MessageBox.Show($"Character '{newCharacter.Name}' created successfully!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private int GetInitialHealth()
        {
            if (raceComboBox.SelectedItem.ToString() == "Drone")
            {
                return 120; // Drones get extra 20 health because you are made of metal duhhhhh
            }
            return 100; // Default health for other races
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFactionComboBox();
            GenerateGun();
            UpdateCharacterAttributes();
        }

        private void UpdateFactionComboBox()
        {
            factionComboBox.Items.Clear();

            switch (raceComboBox.SelectedItem.ToString())
            {
                case "Human":
                    factionComboBox.Items.Add("Human Loyalists");
                    factionComboBox.Items.Add("Human Rebels");
                    break;
                case "Drone":
                    factionComboBox.Items.Add("Drone Loyalists");
                    factionComboBox.Items.Add("Drone Rebels");
                    break;
                case "Synth":
                    factionComboBox.Items.Add("Synth Loyalists");
                    factionComboBox.Items.Add("Synth Rebels");
                    break;
            }

            factionComboBox.SelectedIndex = 0; // Default to first faction
        }

        private int GetStartingCredits(string race)
        {
            return race switch
            {
                "Human" => 1000,
                "Drone" => 500,
                "Synth" => 500,
                _ => 0,
            };
        }

        private void UpdateCharacterAttributes()
        {
            switch (raceComboBox.SelectedItem.ToString())
            {
                case "Human":
                    strengthLabelValue.Text = "1";
                    dexterityLabelValue.Text = "2";
                    intelligenceLabelValue.Text = "1";
                    wisdomLabelValue.Text = "1";
                    charismaLabelValue.Text = "1";
                    break;
                case "Drone":
                    strengthLabelValue.Text = "4";
                    dexterityLabelValue.Text = "1";
                    intelligenceLabelValue.Text = "0";
                    wisdomLabelValue.Text = "0";
                    charismaLabelValue.Text = "0";
                    break;
                case "Synth":
                    strengthLabelValue.Text = "0";
                    dexterityLabelValue.Text = "4";
                    intelligenceLabelValue.Text = "0";
                    wisdomLabelValue.Text = "2";
                    charismaLabelValue.Text = "0";
                    break;
            }
        }

        private int GenerateSeed()
        {
            Random random = new Random();
            return random.Next();
        }

        private void ApplyFactionBuffs(Character character)
        {
            if (character.Faction.Contains("Loyalists"))
            {
                character.Gun.DamageMultiplier += 0.2f; // Buff to starting weapon type
            }
            else if (character.Faction.Contains("Rebels"))
            {
                character.Gun.DamageMultiplier += 0.1f; // Balanced buff to weapons
            }
        }
    }
}

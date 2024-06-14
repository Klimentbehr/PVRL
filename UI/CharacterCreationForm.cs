using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using PVRL.Functions;

namespace PVRL
{
    public partial class CharacterCreationForm : Form
    {
        private Vault vault;
        private List<Character> characters;
        private int pointsLeft = 5;
        private GunGeneration.Gun currentGun;

        public CharacterCreationForm(Vault vault, List<Character> characters)
        {
            InitializeComponent();
            this.vault = vault;
            this.characters = characters;
            GenerateGun();
            UpdatePointsLeftLabel();
        }

        private void GenerateGun()
        {
            GunGeneration gunGen = new GunGeneration();
            currentGun = gunGen.GenerateStartingGun(); // Generate a weak starting gun with poor parts
            generatedGunLabel.Text = $"Generated Gun: {currentGun}";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character
            {
                Name = nameTextBox.Text,
                Race = raceComboBox.SelectedItem.ToString(),
                Age = (int)ageNumericUpDown.Value,
                Strength = (int)strengthNumericUpDown.Value,
                Dexterity = (int)dexterityNumericUpDown.Value,
                Intelligence = (int)intelligenceNumericUpDown.Value,
                Wisdom = (int)wisdomNumericUpDown.Value,
                Charisma = (int)charismaNumericUpDown.Value,
                Health = 100,
                Defense = 10,
                Gun = currentGun,
                Type = Character.CharacterType.Player
            };

            characters.Add(newCharacter); // Add the new character to the list
            vault.AddGun(currentGun); // Add the gun to the vault

            string json = JsonConvert.SerializeObject(newCharacter, Formatting.Indented);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{newCharacter.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, json);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AttributeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int totalPointsUsed = (int)(strengthNumericUpDown.Value + dexterityNumericUpDown.Value + intelligenceNumericUpDown.Value + wisdomNumericUpDown.Value + charismaNumericUpDown.Value);
            pointsLeft = 5 - totalPointsUsed;

            if (pointsLeft < 0)
            {
                NumericUpDown control = sender as NumericUpDown;
                control.ValueChanged -= AttributeNumericUpDown_ValueChanged;
                control.Value -= 1;
                control.ValueChanged += AttributeNumericUpDown_ValueChanged;
                pointsLeft = 0;
            }

            UpdatePointsLeftLabel();
        }

        private void UpdatePointsLeftLabel()
        {
            pointsLeftLabel.Text = $"Points Left: {pointsLeft}";
        }
    }
}

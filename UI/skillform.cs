using System;
using System.Windows.Forms;

namespace PVRL
{
    public partial class SkillForm : Form
    {
        private Character character;
        private int initialSkillPoints;

        public SkillForm(Character character)
        {
            InitializeComponent();
            this.character = character;
            this.initialSkillPoints = character.SkillPoints;
            LoadCharacterSkills();
            UpdatePointsLeftLabel();
        }

        private void LoadCharacterSkills()
        {
            strengthNumericUpDown.Value = character.Strength;
            dexterityNumericUpDown.Value = character.Dexterity;
            intelligenceNumericUpDown.Value = character.Intelligence;
            wisdomNumericUpDown.Value = character.Wisdom;
            charismaNumericUpDown.Value = character.Charisma;
        }

        private void UpdatePointsLeftLabel()
        {
            pointsLeftLabel.Text = $"Points Left: {character.SkillPoints}";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int pointsSpent = (int)(strengthNumericUpDown.Value +
                                    dexterityNumericUpDown.Value +
                                    intelligenceNumericUpDown.Value +
                                    wisdomNumericUpDown.Value +
                                    charismaNumericUpDown.Value) -
                                    (character.Strength + character.Dexterity +
                                    character.Intelligence + character.Wisdom +
                                    character.Charisma);

            character.Strength = (int)strengthNumericUpDown.Value;
            character.Dexterity = (int)dexterityNumericUpDown.Value;
            character.Intelligence = (int)intelligenceNumericUpDown.Value;
            character.Wisdom = (int)wisdomNumericUpDown.Value;
            character.Charisma = (int)charismaNumericUpDown.Value;

            character.SkillPoints = Math.Max(0, initialSkillPoints - pointsSpent);
            Close();
        }

        private void AttributeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int pointsSpent = (int)(strengthNumericUpDown.Value +
                                    dexterityNumericUpDown.Value +
                                    intelligenceNumericUpDown.Value +
                                    wisdomNumericUpDown.Value +
                                    charismaNumericUpDown.Value) -
                                    (character.Strength + character.Dexterity +
                                    character.Intelligence + character.Wisdom +
                                    character.Charisma);

            int pointsLeft = initialSkillPoints - pointsSpent;

            if (pointsLeft < 0)
            {
                NumericUpDown attributeControl = (NumericUpDown)sender;
                attributeControl.Value--;
                pointsLeft = initialSkillPoints - (int)(strengthNumericUpDown.Value +
                                                       dexterityNumericUpDown.Value +
                                                       intelligenceNumericUpDown.Value +
                                                       wisdomNumericUpDown.Value +
                                                       charismaNumericUpDown.Value);
            }

            character.SkillPoints = pointsLeft;
            UpdatePointsLeftLabel();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

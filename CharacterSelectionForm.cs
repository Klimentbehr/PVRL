using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PVRL
{
    public partial class CharacterSelectionForm : Form
    {
        private List<Character> characters;

        public Character SelectedCharacter { get; private set; }

        public CharacterSelectionForm(List<Character> characters)
        {
            InitializeComponent();
            this.characters = characters;
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

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (characterComboBox.SelectedIndex != -1)
            {
                string selectedCharacterName = characterComboBox.SelectedItem.ToString();
                SelectedCharacter = characters.FirstOrDefault(c => c.Name == selectedCharacterName);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a character.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

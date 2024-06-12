using System;
using System.Windows.Forms;
using Main;

namespace PVRL
{
    public partial class DifficultySelectionForm : Form
    {
        public Main.DifficultyLevel SelectedDifficulty { get; private set; }

        public DifficultySelectionForm()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = Main.DifficultyLevel.Easy;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = Main.DifficultyLevel.Normal;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = Main.DifficultyLevel.Hard;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BossSlaughterButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = Main.DifficultyLevel.BossSlaughter;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

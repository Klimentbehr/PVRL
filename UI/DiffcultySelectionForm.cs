using System;
using System.Windows.Forms;
using PVRL.Functions;

namespace PVRL
{
    public partial class DifficultySelectionForm : Form
    {
        public DifficultyLevel SelectedDifficulty { get; private set; }

        public DifficultySelectionForm()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = DifficultyLevel.Easy;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = DifficultyLevel.Normal;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = DifficultyLevel.Hard;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BossSlaughterButton_Click(object sender, EventArgs e)
        {
            SelectedDifficulty = DifficultyLevel.BossSlaughter;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

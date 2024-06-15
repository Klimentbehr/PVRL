using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public partial class ManageCharacterControl : UserControl
    {
        private Character character;
        private Vault vault;

        public ManageCharacterControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }

        public void SetCharacterAndVault(Character character, Vault vault)
        {
            this.character = character;
            this.vault = vault;
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(new List<Character> { character }, vault);
            inventoryForm.ShowDialog();
        }

        private void SkillsButton_Click(object sender, EventArgs e)
        {
            SkillForm skillForm = new SkillForm(character);
            skillForm.ShowDialog();
        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            CraftingForm craftingForm = new CraftingForm(new List<Character> { character }, vault);
            craftingForm.ShowDialog();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            StoreForm storeForm = new StoreForm(character, vault);
            storeForm.ShowDialog();
        }

        private void ReturnHomeButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.ReturnToHome();
        }

        private void ManageCharacterControl_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        public void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int buttonWidth = (int)(this.ClientSize.Width * 0.3);
            int buttonHeight = (int)(this.ClientSize.Height * 0.1);
            int spacing = (int)(buttonHeight * 0.1);

            inventoryButton.Size = new Size(buttonWidth, buttonHeight);
            skillsButton.Size = new Size(buttonWidth, buttonHeight);
            craftingButton.Size = new Size(buttonWidth, buttonHeight);
            storeButton.Size = new Size(buttonWidth, buttonHeight);
            returnHomeButton.Size = new Size(buttonWidth, buttonHeight);

            inventoryButton.Location = new Point(centerX - buttonWidth / 2, centerY - 2 * buttonHeight - 2 * spacing);
            skillsButton.Location = new Point(centerX - buttonWidth / 2, centerY - buttonHeight - spacing);
            craftingButton.Location = new Point(centerX - buttonWidth / 2, centerY);
            storeButton.Location = new Point(centerX - buttonWidth / 2, centerY + buttonHeight + spacing);
            returnHomeButton.Location = new Point(centerX - buttonWidth / 2, centerY + 2 * buttonHeight + 2 * spacing);

            int buttonFontSize = (int)(buttonHeight * 0.25);
            inventoryButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            skillsButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            craftingButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            storeButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
            returnHomeButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular, GraphicsUnit.Point);
        }
    }
}


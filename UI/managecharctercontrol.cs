using System;
using System.Collections.Generic;
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
    }
}

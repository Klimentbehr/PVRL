using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PVRL
{
    public partial class HealingItemSelectionForm : Form
    {
        public HealingItem SelectedHealingItem { get; private set; }
        private List<HealingItem> healingItems;

        public HealingItemSelectionForm(List<HealingItem> healingItems)
        {
            InitializeComponent();
            this.healingItems = healingItems;
            LoadHealingItems();
        }

        private void LoadHealingItems()
        {
            healingItemsListBox.Items.Clear();
            foreach (var item in healingItems)
            {
                healingItemsListBox.Items.Add(item.Name);
            }
        }

        private void healingItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (healingItemsListBox.SelectedIndex >= 0)
            {
                SelectedHealingItem = healingItems[healingItemsListBox.SelectedIndex];
                healingItemDetailsTextBox.Text = SelectedHealingItem.ToString().Replace("\n", Environment.NewLine);
            }
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            if (SelectedHealingItem != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a healing item.");
            }
        }
    }
}

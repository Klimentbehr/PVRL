namespace PVRL
{
    partial class HealingItemSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox healingItemsListBox;
        private TextBox healingItemDetailsTextBox;
        private Button useButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealingItemSelectionForm));
            healingItemsListBox = new ListBox();
            healingItemDetailsTextBox = new TextBox();
            useButton = new Button();
            SuspendLayout();
            // 
            // healingItemsListBox
            // 
            healingItemsListBox.FormattingEnabled = true;
            healingItemsListBox.ItemHeight = 15;
            healingItemsListBox.Location = new Point(12, 12);
            healingItemsListBox.Name = "healingItemsListBox";
            healingItemsListBox.Size = new Size(200, 244);
            healingItemsListBox.TabIndex = 0;
            healingItemsListBox.SelectedIndexChanged += healingItemsListBox_SelectedIndexChanged;
            // 
            // healingItemDetailsTextBox
            // 
            healingItemDetailsTextBox.Location = new Point(218, 12);
            healingItemDetailsTextBox.Multiline = true;
            healingItemDetailsTextBox.Name = "healingItemDetailsTextBox";
            healingItemDetailsTextBox.ReadOnly = true;
            healingItemDetailsTextBox.Size = new Size(250, 244);
            healingItemDetailsTextBox.TabIndex = 1;
            // 
            // useButton
            // 
            useButton.Location = new Point(218, 262);
            useButton.Name = "useButton";
            useButton.Size = new Size(75, 23);
            useButton.TabIndex = 2;
            useButton.Text = "Use";
            useButton.UseVisualStyleBackColor = true;
            useButton.Click += useButton_Click;
            // 
            // HealingItemSelectionForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(492, 308);
            Controls.Add(useButton);
            Controls.Add(healingItemDetailsTextBox);
            Controls.Add(healingItemsListBox);
            Name = "HealingItemSelectionForm";
            Text = "Select Healing Item";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

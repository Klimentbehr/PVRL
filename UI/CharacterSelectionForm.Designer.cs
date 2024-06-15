namespace PVRL
{
    partial class CharacterSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox characterComboBox;
        private Label selectCharacterLabel;
        private Button confirmButton;
        private Button cancelButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelectionForm));
            this.characterComboBox = new ComboBox();
            this.selectCharacterLabel = new Label();
            this.confirmButton = new Button();
            this.cancelButton = new Button();
            this.SuspendLayout();
            // 
            // characterComboBox
            // 
            this.characterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.characterComboBox.FormattingEnabled = true;
            this.characterComboBox.Location = new Point(12, 25);
            this.characterComboBox.Name = "characterComboBox";
            this.characterComboBox.Size = new Size(260, 23);
            this.characterComboBox.TabIndex = 0;
            // 
            // selectCharacterLabel
            // 
            this.selectCharacterLabel.AutoSize = true;
            this.selectCharacterLabel.BackColor = Color.Transparent;
            this.selectCharacterLabel.ForeColor = SystemColors.ButtonHighlight;
            this.selectCharacterLabel.Location = new Point(12, 7);
            this.selectCharacterLabel.Name = "selectCharacterLabel";
            this.selectCharacterLabel.Size = new Size(95, 15);
            this.selectCharacterLabel.TabIndex = 1;
            this.selectCharacterLabel.Text = "Select Character:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new Point(116, 54);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new Point(197, 54);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new EventHandler(this.CancelButton_Click);
            // 
            // CharacterSelectionForm
            // 
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(284, 91);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.selectCharacterLabel);
            this.Controls.Add(this.characterComboBox);
            this.Name = "CharacterSelectionForm";
            this.Text = "Select Character";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

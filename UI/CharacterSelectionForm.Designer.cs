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
            characterComboBox = new ComboBox();
            selectCharacterLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // characterComboBox
            // 
            characterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            characterComboBox.FormattingEnabled = true;
            characterComboBox.Location = new Point(12, 25);
            characterComboBox.Name = "characterComboBox";
            characterComboBox.Size = new Size(260, 23);
            characterComboBox.TabIndex = 0;
            // 
            // selectCharacterLabel
            // 
            selectCharacterLabel.AutoSize = true;
            selectCharacterLabel.BackColor = Color.Transparent;
            selectCharacterLabel.ForeColor = SystemColors.ButtonHighlight;
            selectCharacterLabel.Location = new Point(12, 7);
            selectCharacterLabel.Name = "selectCharacterLabel";
            selectCharacterLabel.Size = new Size(95, 15);
            selectCharacterLabel.TabIndex = 1;
            selectCharacterLabel.Text = "Select Character:";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(116, 54);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(197, 54);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // CharacterSelectionForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(338, 111);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(selectCharacterLabel);
            Controls.Add(characterComboBox);
            Name = "CharacterSelectionForm";
            Text = "Select Character";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

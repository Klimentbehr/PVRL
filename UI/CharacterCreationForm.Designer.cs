namespace PVRL
{
    partial class CharacterCreationForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private ComboBox raceComboBox;
        private ComboBox factionComboBox;
        private NumericUpDown ageNumericUpDown;
        private Label nameLabel;
        private Label raceLabel;
        private Label factionLabel;
        private Label ageLabel;
        private Label strengthLabel;
        private Label dexterityLabel;
        private Label intelligenceLabel;
        private Label wisdomLabel;
        private Label charismaLabel;
        private Label strengthLabelValue;
        private Label dexterityLabelValue;
        private Label intelligenceLabelValue;
        private Label wisdomLabelValue;
        private Label charismaLabelValue;
        private Button confirmButton;
        private Button cancelButton;
        private Label generatedGunLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreationForm));
            nameTextBox = new TextBox();
            raceComboBox = new ComboBox();
            factionComboBox = new ComboBox();
            ageNumericUpDown = new NumericUpDown();
            nameLabel = new Label();
            raceLabel = new Label();
            factionLabel = new Label();
            ageLabel = new Label();
            strengthLabel = new Label();
            dexterityLabel = new Label();
            intelligenceLabel = new Label();
            wisdomLabel = new Label();
            charismaLabel = new Label();
            strengthLabelValue = new Label();
            dexterityLabelValue = new Label();
            intelligenceLabelValue = new Label();
            wisdomLabelValue = new Label();
            charismaLabelValue = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            generatedGunLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(220, 52);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(263, 32);
            nameTextBox.TabIndex = 0;
            // 
            // raceComboBox
            // 
            raceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            raceComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            raceComboBox.FormattingEnabled = true;
            raceComboBox.Items.AddRange(new object[] { "Human", "Drone", "Synth" });
            raceComboBox.Location = new Point(220, 99);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(263, 33);
            raceComboBox.TabIndex = 1;
            raceComboBox.SelectedIndexChanged += RaceComboBox_SelectedIndexChanged;
            // 
            // factionComboBox
            // 
            factionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            factionComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            factionComboBox.FormattingEnabled = true;
            factionComboBox.Location = new Point(220, 146);
            factionComboBox.Name = "factionComboBox";
            factionComboBox.Size = new Size(263, 33);
            factionComboBox.TabIndex = 2;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ageNumericUpDown.Location = new Point(220, 193);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(262, 32);
            ageNumericUpDown.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ButtonFace;
            nameLabel.Location = new Point(44, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 37);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.BackColor = Color.Transparent;
            raceLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            raceLabel.ForeColor = SystemColors.ButtonFace;
            raceLabel.Location = new Point(44, 94);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(73, 37);
            raceLabel.TabIndex = 5;
            raceLabel.Text = "Race";
            // 
            // factionLabel
            // 
            factionLabel.AutoSize = true;
            factionLabel.BackColor = Color.Transparent;
            factionLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            factionLabel.ForeColor = SystemColors.ButtonFace;
            factionLabel.Location = new Point(44, 141);
            factionLabel.Name = "factionLabel";
            factionLabel.Size = new Size(103, 37);
            factionLabel.TabIndex = 6;
            factionLabel.Text = "Faction";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.ForeColor = SystemColors.ButtonFace;
            ageLabel.Location = new Point(44, 188);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(64, 37);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age";
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.BackColor = Color.Transparent;
            strengthLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            strengthLabel.ForeColor = SystemColors.ButtonFace;
            strengthLabel.Location = new Point(44, 275);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(117, 37);
            strengthLabel.TabIndex = 8;
            strengthLabel.Text = "Strength";
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.BackColor = Color.Transparent;
            dexterityLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dexterityLabel.ForeColor = SystemColors.ButtonFace;
            dexterityLabel.Location = new Point(44, 321);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(123, 37);
            dexterityLabel.TabIndex = 9;
            dexterityLabel.Text = "Dexterity";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.BackColor = Color.Transparent;
            intelligenceLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            intelligenceLabel.ForeColor = SystemColors.ButtonFace;
            intelligenceLabel.Location = new Point(44, 368);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(154, 37);
            intelligenceLabel.TabIndex = 10;
            intelligenceLabel.Text = "Intelligence";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.BackColor = Color.Transparent;
            wisdomLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wisdomLabel.ForeColor = SystemColors.ButtonFace;
            wisdomLabel.Location = new Point(44, 415);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(115, 37);
            wisdomLabel.TabIndex = 11;
            wisdomLabel.Text = "Wisdom";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.BackColor = Color.Transparent;
            charismaLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            charismaLabel.ForeColor = SystemColors.ButtonFace;
            charismaLabel.Location = new Point(44, 462);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(127, 37);
            charismaLabel.TabIndex = 12;
            charismaLabel.Text = "Charisma";
            // 
            // strengthLabelValue
            // 
            strengthLabelValue.AutoSize = true;
            strengthLabelValue.BackColor = Color.Transparent;
            strengthLabelValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            strengthLabelValue.ForeColor = SystemColors.ButtonFace;
            strengthLabelValue.Location = new Point(220, 275);
            strengthLabelValue.Name = "strengthLabelValue";
            strengthLabelValue.Size = new Size(32, 37);
            strengthLabelValue.TabIndex = 13;
            strengthLabelValue.Text = "0";
            // 
            // dexterityLabelValue
            // 
            dexterityLabelValue.AutoSize = true;
            dexterityLabelValue.BackColor = Color.Transparent;
            dexterityLabelValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dexterityLabelValue.ForeColor = SystemColors.ButtonFace;
            dexterityLabelValue.Location = new Point(220, 321);
            dexterityLabelValue.Name = "dexterityLabelValue";
            dexterityLabelValue.Size = new Size(32, 37);
            dexterityLabelValue.TabIndex = 14;
            dexterityLabelValue.Text = "0";
            // 
            // intelligenceLabelValue
            // 
            intelligenceLabelValue.AutoSize = true;
            intelligenceLabelValue.BackColor = Color.Transparent;
            intelligenceLabelValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            intelligenceLabelValue.ForeColor = SystemColors.ButtonFace;
            intelligenceLabelValue.Location = new Point(220, 368);
            intelligenceLabelValue.Name = "intelligenceLabelValue";
            intelligenceLabelValue.Size = new Size(32, 37);
            intelligenceLabelValue.TabIndex = 15;
            intelligenceLabelValue.Text = "0";
            // 
            // wisdomLabelValue
            // 
            wisdomLabelValue.AutoSize = true;
            wisdomLabelValue.BackColor = Color.Transparent;
            wisdomLabelValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wisdomLabelValue.ForeColor = SystemColors.ButtonFace;
            wisdomLabelValue.Location = new Point(220, 415);
            wisdomLabelValue.Name = "wisdomLabelValue";
            wisdomLabelValue.Size = new Size(32, 37);
            wisdomLabelValue.TabIndex = 16;
            wisdomLabelValue.Text = "0";
            // 
            // charismaLabelValue
            // 
            charismaLabelValue.AutoSize = true;
            charismaLabelValue.BackColor = Color.Transparent;
            charismaLabelValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            charismaLabelValue.ForeColor = SystemColors.ButtonFace;
            charismaLabelValue.Location = new Point(220, 462);
            charismaLabelValue.Name = "charismaLabelValue";
            charismaLabelValue.Size = new Size(32, 37);
            charismaLabelValue.TabIndex = 17;
            charismaLabelValue.Text = "0";
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(57, 955);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(281, 66);
            confirmButton.TabIndex = 18;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(1247, 955);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(281, 66);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // generatedGunLabel
            // 
            generatedGunLabel.AutoSize = true;
            generatedGunLabel.BackColor = Color.Transparent;
            generatedGunLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            generatedGunLabel.ForeColor = SystemColors.ButtonFace;
            generatedGunLabel.Location = new Point(915, 50);
            generatedGunLabel.Name = "generatedGunLabel";
            generatedGunLabel.Size = new Size(254, 46);
            generatedGunLabel.TabIndex = 20;
            generatedGunLabel.Text = "Generated Gun:";
            generatedGunLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CharacterCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1930, 1072);
            Controls.Add(nameTextBox);
            Controls.Add(raceComboBox);
            Controls.Add(factionComboBox);
            Controls.Add(ageNumericUpDown);
            Controls.Add(nameLabel);
            Controls.Add(raceLabel);
            Controls.Add(factionLabel);
            Controls.Add(ageLabel);
            Controls.Add(strengthLabel);
            Controls.Add(dexterityLabel);
            Controls.Add(intelligenceLabel);
            Controls.Add(wisdomLabel);
            Controls.Add(charismaLabel);
            Controls.Add(strengthLabelValue);
            Controls.Add(dexterityLabelValue);
            Controls.Add(intelligenceLabelValue);
            Controls.Add(wisdomLabelValue);
            Controls.Add(charismaLabelValue);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(generatedGunLabel);
            Name = "CharacterCreationForm";
            Text = "Character Creation";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

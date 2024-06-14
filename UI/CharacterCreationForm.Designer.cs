namespace PVRL
{
    partial class CharacterCreationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label raceLabel;
        private ComboBox raceComboBox;
        private Label ageLabel;
        private NumericUpDown ageNumericUpDown;
        private Label strengthLabel;
        private NumericUpDown strengthNumericUpDown;
        private Label dexterityLabel;
        private NumericUpDown dexterityNumericUpDown;
        private Label intelligenceLabel;
        private NumericUpDown intelligenceNumericUpDown;
        private Label wisdomLabel;
        private NumericUpDown wisdomNumericUpDown;
        private Label charismaLabel;
        private NumericUpDown charismaNumericUpDown;
        private Label pointsLeftLabel;
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            raceLabel = new Label();
            raceComboBox = new ComboBox();
            ageLabel = new Label();
            ageNumericUpDown = new NumericUpDown();
            strengthLabel = new Label();
            strengthNumericUpDown = new NumericUpDown();
            dexterityLabel = new Label();
            dexterityNumericUpDown = new NumericUpDown();
            intelligenceLabel = new Label();
            intelligenceNumericUpDown = new NumericUpDown();
            wisdomLabel = new Label();
            wisdomNumericUpDown = new NumericUpDown();
            charismaLabel = new Label();
            charismaNumericUpDown = new NumericUpDown();
            pointsLeftLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            generatedGunLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dexterityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intelligenceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wisdomNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charismaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(12, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(92, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(120, 23);
            nameTextBox.TabIndex = 1;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.BackColor = Color.Transparent;
            raceLabel.ForeColor = SystemColors.ButtonHighlight;
            raceLabel.Location = new Point(12, 45);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(35, 15);
            raceLabel.TabIndex = 2;
            raceLabel.Text = "Race:";
            // 
            // raceComboBox
            // 
            raceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            raceComboBox.FormattingEnabled = true;
            raceComboBox.Items.AddRange(new object[] { "Race 1", "Race 2", "Race 3" });
            raceComboBox.Location = new Point(92, 42);
            raceComboBox.Name = "raceComboBox";
            raceComboBox.Size = new Size(120, 23);
            raceComboBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.ForeColor = SystemColors.ButtonHighlight;
            ageLabel.Location = new Point(12, 75);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(92, 73);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(120, 23);
            ageNumericUpDown.TabIndex = 5;
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.BackColor = Color.Transparent;
            strengthLabel.ForeColor = SystemColors.ButtonHighlight;
            strengthLabel.Location = new Point(12, 105);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(55, 15);
            strengthLabel.TabIndex = 6;
            strengthLabel.Text = "Strength:";
            // 
            // strengthNumericUpDown
            // 
            strengthNumericUpDown.Location = new Point(92, 103);
            strengthNumericUpDown.Name = "strengthNumericUpDown";
            strengthNumericUpDown.ReadOnly = true;
            strengthNumericUpDown.Size = new Size(120, 23);
            strengthNumericUpDown.TabIndex = 7;
            strengthNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.BackColor = Color.Transparent;
            dexterityLabel.ForeColor = SystemColors.ButtonHighlight;
            dexterityLabel.Location = new Point(12, 135);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(57, 15);
            dexterityLabel.TabIndex = 8;
            dexterityLabel.Text = "Dexterity:";
            // 
            // dexterityNumericUpDown
            // 
            dexterityNumericUpDown.Location = new Point(92, 133);
            dexterityNumericUpDown.Name = "dexterityNumericUpDown";
            dexterityNumericUpDown.ReadOnly = true;
            dexterityNumericUpDown.Size = new Size(120, 23);
            dexterityNumericUpDown.TabIndex = 9;
            dexterityNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.BackColor = Color.Transparent;
            intelligenceLabel.ForeColor = SystemColors.ButtonHighlight;
            intelligenceLabel.Location = new Point(12, 163);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(71, 15);
            intelligenceLabel.TabIndex = 10;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // intelligenceNumericUpDown
            // 
            intelligenceNumericUpDown.Location = new Point(92, 163);
            intelligenceNumericUpDown.Name = "intelligenceNumericUpDown";
            intelligenceNumericUpDown.ReadOnly = true;
            intelligenceNumericUpDown.Size = new Size(120, 23);
            intelligenceNumericUpDown.TabIndex = 11;
            intelligenceNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.BackColor = Color.Transparent;
            wisdomLabel.ForeColor = SystemColors.ButtonHighlight;
            wisdomLabel.Location = new Point(12, 195);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(54, 15);
            wisdomLabel.TabIndex = 12;
            wisdomLabel.Text = "Wisdom:";
            // 
            // wisdomNumericUpDown
            // 
            wisdomNumericUpDown.Location = new Point(92, 193);
            wisdomNumericUpDown.Name = "wisdomNumericUpDown";
            wisdomNumericUpDown.ReadOnly = true;
            wisdomNumericUpDown.Size = new Size(120, 23);
            wisdomNumericUpDown.TabIndex = 13;
            wisdomNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.BackColor = Color.Transparent;
            charismaLabel.ForeColor = SystemColors.ButtonHighlight;
            charismaLabel.Location = new Point(12, 225);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(60, 15);
            charismaLabel.TabIndex = 14;
            charismaLabel.Text = "Charisma:";
            // 
            // charismaNumericUpDown
            // 
            charismaNumericUpDown.Location = new Point(92, 223);
            charismaNumericUpDown.Name = "charismaNumericUpDown";
            charismaNumericUpDown.ReadOnly = true;
            charismaNumericUpDown.Size = new Size(120, 23);
            charismaNumericUpDown.TabIndex = 15;
            charismaNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // pointsLeftLabel
            // 
            pointsLeftLabel.AutoSize = true;
            pointsLeftLabel.BackColor = Color.Transparent;
            pointsLeftLabel.ForeColor = SystemColors.ButtonHighlight;
            pointsLeftLabel.Location = new Point(12, 255);
            pointsLeftLabel.Name = "pointsLeftLabel";
            pointsLeftLabel.Size = new Size(66, 15);
            pointsLeftLabel.TabIndex = 16;
            pointsLeftLabel.Text = "Points Left:";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(92, 278);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(120, 23);
            confirmButton.TabIndex = 17;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(92, 307);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // generatedGunLabel
            // 
            generatedGunLabel.AutoSize = true;
            generatedGunLabel.BackColor = Color.Transparent;
            generatedGunLabel.ForeColor = SystemColors.ButtonHighlight;
            generatedGunLabel.Location = new Point(218, 20);
            generatedGunLabel.Name = "generatedGunLabel";
            generatedGunLabel.Size = new Size(89, 15);
            generatedGunLabel.TabIndex = 19;
            generatedGunLabel.Text = "Generated Gun:";
            // 
            // CharacterCreationForm
            // 
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(417, 487);
            Controls.Add(generatedGunLabel);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(pointsLeftLabel);
            Controls.Add(charismaNumericUpDown);
            Controls.Add(charismaLabel);
            Controls.Add(wisdomNumericUpDown);
            Controls.Add(wisdomLabel);
            Controls.Add(intelligenceNumericUpDown);
            Controls.Add(intelligenceLabel);
            Controls.Add(dexterityNumericUpDown);
            Controls.Add(dexterityLabel);
            Controls.Add(strengthNumericUpDown);
            Controls.Add(strengthLabel);
            Controls.Add(ageNumericUpDown);
            Controls.Add(ageLabel);
            Controls.Add(raceComboBox);
            Controls.Add(raceLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "CharacterCreationForm";
            Text = "Character Creation";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dexterityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)intelligenceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)wisdomNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)charismaNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

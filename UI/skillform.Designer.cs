namespace PVRL
{
    partial class SkillForm
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillForm));
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
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dexterityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intelligenceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wisdomNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charismaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.BackColor = Color.Transparent;
            strengthLabel.ForeColor = SystemColors.ButtonFace;
            strengthLabel.Location = new Point(12, 15);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(55, 15);
            strengthLabel.TabIndex = 0;
            strengthLabel.Text = "Strength:";
            // 
            // strengthNumericUpDown
            // 
            strengthNumericUpDown.Location = new Point(80, 13);
            strengthNumericUpDown.Name = "strengthNumericUpDown";
            strengthNumericUpDown.Size = new Size(120, 23);
            strengthNumericUpDown.TabIndex = 1;
            strengthNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.BackColor = Color.Transparent;
            dexterityLabel.ForeColor = SystemColors.ButtonFace;
            dexterityLabel.Location = new Point(12, 45);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(57, 15);
            dexterityLabel.TabIndex = 2;
            dexterityLabel.Text = "Dexterity:";
            // 
            // dexterityNumericUpDown
            // 
            dexterityNumericUpDown.Location = new Point(80, 43);
            dexterityNumericUpDown.Name = "dexterityNumericUpDown";
            dexterityNumericUpDown.Size = new Size(120, 23);
            dexterityNumericUpDown.TabIndex = 3;
            dexterityNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.BackColor = Color.Transparent;
            intelligenceLabel.ForeColor = SystemColors.ButtonFace;
            intelligenceLabel.Location = new Point(12, 75);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(71, 15);
            intelligenceLabel.TabIndex = 4;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // intelligenceNumericUpDown
            // 
            intelligenceNumericUpDown.Location = new Point(80, 73);
            intelligenceNumericUpDown.Name = "intelligenceNumericUpDown";
            intelligenceNumericUpDown.Size = new Size(120, 23);
            intelligenceNumericUpDown.TabIndex = 5;
            intelligenceNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.BackColor = Color.Transparent;
            wisdomLabel.ForeColor = SystemColors.ButtonFace;
            wisdomLabel.Location = new Point(12, 105);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(54, 15);
            wisdomLabel.TabIndex = 6;
            wisdomLabel.Text = "Wisdom:";
            // 
            // wisdomNumericUpDown
            // 
            wisdomNumericUpDown.Location = new Point(80, 103);
            wisdomNumericUpDown.Name = "wisdomNumericUpDown";
            wisdomNumericUpDown.Size = new Size(120, 23);
            wisdomNumericUpDown.TabIndex = 7;
            wisdomNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.BackColor = Color.Transparent;
            charismaLabel.ForeColor = SystemColors.ButtonFace;
            charismaLabel.Location = new Point(12, 135);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(60, 15);
            charismaLabel.TabIndex = 8;
            charismaLabel.Text = "Charisma:";
            // 
            // charismaNumericUpDown
            // 
            charismaNumericUpDown.Location = new Point(80, 133);
            charismaNumericUpDown.Name = "charismaNumericUpDown";
            charismaNumericUpDown.Size = new Size(120, 23);
            charismaNumericUpDown.TabIndex = 9;
            charismaNumericUpDown.ValueChanged += AttributeNumericUpDown_ValueChanged;
            // 
            // pointsLeftLabel
            // 
            pointsLeftLabel.AutoSize = true;
            pointsLeftLabel.BackColor = Color.Transparent;
            pointsLeftLabel.ForeColor = SystemColors.ButtonFace;
            pointsLeftLabel.Location = new Point(12, 165);
            pointsLeftLabel.Name = "pointsLeftLabel";
            pointsLeftLabel.Size = new Size(66, 15);
            pointsLeftLabel.TabIndex = 10;
            pointsLeftLabel.Text = "Points Left:";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(80, 190);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(120, 23);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(80, 220);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // SkillForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(220, 260);
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
            Name = "SkillForm";
            Text = "Update Skills";
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

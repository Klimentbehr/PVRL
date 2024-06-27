namespace PVRL
{
    partial class SkillForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomTabControl tabControl;
        private CustomTabPage offenseTabPage;
        private CustomTabPage defenseTabPage;
        private CustomTabPage supportTabPage;
        private Button confirmButton;
        private Button cancelButton;
        private Label skillPointsLabel;
        private ComboBox characterComboBox;
        private Label characterInfoLabel;

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
            tabControl = new CustomTabControl();
            offenseTabPage = new CustomTabPage();
            defenseTabPage = new CustomTabPage();
            supportTabPage = new CustomTabPage();
            confirmButton = new Button();
            cancelButton = new Button();
            skillPointsLabel = new Label();
            characterComboBox = new ComboBox();
            characterInfoLabel = new Label();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(offenseTabPage);
            tabControl.Controls.Add(defenseTabPage);
            tabControl.Controls.Add(supportTabPage);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(150, 40);
            tabControl.Location = new Point(10, 120);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1337, 814);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // offenseTabPage
            // 
            offenseTabPage.BackColor = SystemColors.Info;
            offenseTabPage.Location = new Point(4, 44);
            offenseTabPage.Name = "offenseTabPage";
            offenseTabPage.Padding = new Padding(3);
            offenseTabPage.Size = new Size(1329, 766);
            offenseTabPage.TabIndex = 0;
            offenseTabPage.Text = "Offense";
            // 
            // defenseTabPage
            // 
            defenseTabPage.BackColor = SystemColors.Info;
            defenseTabPage.Location = new Point(4, 44);
            defenseTabPage.Name = "defenseTabPage";
            defenseTabPage.Padding = new Padding(3);
            defenseTabPage.Size = new Size(1528, 766);
            defenseTabPage.TabIndex = 1;
            defenseTabPage.Text = "Defense";
            // 
            // supportTabPage
            // 
            supportTabPage.BackColor = SystemColors.Info;
            supportTabPage.Location = new Point(4, 44);
            supportTabPage.Name = "supportTabPage";
            supportTabPage.Padding = new Padding(3);
            supportTabPage.Size = new Size(1528, 766);
            supportTabPage.TabIndex = 2;
            supportTabPage.Text = "Support";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(170, 940);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(150, 50);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(10, 940);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 50);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // skillPointsLabel
            // 
            skillPointsLabel.AutoSize = true;
            skillPointsLabel.BackColor = Color.Transparent;
            skillPointsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            skillPointsLabel.ForeColor = SystemColors.ButtonFace;
            skillPointsLabel.Location = new Point(1353, 120);
            skillPointsLabel.Name = "skillPointsLabel";
            skillPointsLabel.Size = new Size(153, 32);
            skillPointsLabel.TabIndex = 3;
            skillPointsLabel.Text = "Skill Points: 0";
            // 
            // characterComboBox
            // 
            characterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            characterComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterComboBox.FormattingEnabled = true;
            characterComboBox.Location = new Point(14, 74);
            characterComboBox.Name = "characterComboBox";
            characterComboBox.Size = new Size(300, 40);
            characterComboBox.TabIndex = 4;
            characterComboBox.SelectedIndexChanged += CharacterComboBox_SelectedIndexChanged;
            // 
            // characterInfoLabel
            // 
            characterInfoLabel.AutoSize = true;
            characterInfoLabel.BackColor = Color.Transparent;
            characterInfoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterInfoLabel.ForeColor = SystemColors.ButtonFace;
            characterInfoLabel.Location = new Point(1353, 170);
            characterInfoLabel.Name = "characterInfoLabel";
            characterInfoLabel.Size = new Size(169, 32);
            characterInfoLabel.TabIndex = 5;
            characterInfoLabel.Text = "Character Info:";
            // 
            // SkillForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(characterInfoLabel);
            Controls.Add(characterComboBox);
            Controls.Add(skillPointsLabel);
            Controls.Add(tabControl);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SkillForm";
            Text = "Skill Tree";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

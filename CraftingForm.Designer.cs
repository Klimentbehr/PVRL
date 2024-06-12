namespace PVRL
{
    partial class CraftingForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox characterListBox;
        private ListBox vaultListBox;
        private ListBox partsListBox;
        private Label characterGunLabel;
        private TextBox characterGunDetailsTextBox;
        private TextBox vaultGunDetailsTextBox;
        private Button disassembleGunButton;
        private Button upgradeGunButton;
        private Button renameGunButton;
        private ComboBox partTypeComboBox;
        private ComboBox partQualityComboBox;
        private TextBox gunNameTextBox;
        private Label gunNameLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftingForm));
            characterListBox = new ListBox();
            vaultListBox = new ListBox();
            partsListBox = new ListBox();
            characterGunLabel = new Label();
            characterGunDetailsTextBox = new TextBox();
            vaultGunDetailsTextBox = new TextBox();
            disassembleGunButton = new Button();
            upgradeGunButton = new Button();
            renameGunButton = new Button();
            partTypeComboBox = new ComboBox();
            partQualityComboBox = new ComboBox();
            gunNameTextBox = new TextBox();
            gunNameLabel = new Label();
            SuspendLayout();
            // 
            // characterListBox
            // 
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 15;
            characterListBox.Location = new Point(12, 12);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(153, 94);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += characterListBox_SelectedIndexChanged;
            // 
            // vaultListBox
            // 
            vaultListBox.FormattingEnabled = true;
            vaultListBox.ItemHeight = 15;
            vaultListBox.Location = new Point(171, 12);
            vaultListBox.Name = "vaultListBox";
            vaultListBox.Size = new Size(195, 94);
            vaultListBox.TabIndex = 1;
            vaultListBox.SelectedIndexChanged += vaultListBox_SelectedIndexChanged;
            // 
            // partsListBox
            // 
            partsListBox.FormattingEnabled = true;
            partsListBox.ItemHeight = 15;
            partsListBox.Location = new Point(372, 12);
            partsListBox.Name = "partsListBox";
            partsListBox.Size = new Size(200, 94);
            partsListBox.TabIndex = 2;
            // 
            // characterGunLabel
            // 
            characterGunLabel.AutoSize = true;
            characterGunLabel.BackColor = Color.Transparent;
            characterGunLabel.ForeColor = SystemColors.ButtonHighlight;
            characterGunLabel.Location = new Point(12, 120);
            characterGunLabel.Name = "characterGunLabel";
            characterGunLabel.Size = new Size(101, 15);
            characterGunLabel.TabIndex = 3;
            characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterGunDetailsTextBox
            // 
            characterGunDetailsTextBox.Location = new Point(12, 150);
            characterGunDetailsTextBox.Multiline = true;
            characterGunDetailsTextBox.Name = "characterGunDetailsTextBox";
            characterGunDetailsTextBox.ReadOnly = true; // Set to read-only
            characterGunDetailsTextBox.Size = new Size(153, 276);
            characterGunDetailsTextBox.TabIndex = 4;
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.Location = new Point(171, 150);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.ReadOnly = true; // Set to read-only
            vaultGunDetailsTextBox.Size = new Size(195, 276);
            vaultGunDetailsTextBox.TabIndex = 5;
            // 
            // disassembleGunButton
            // 
            disassembleGunButton.Location = new Point(372, 150);
            disassembleGunButton.Name = "disassembleGunButton";
            disassembleGunButton.Size = new Size(120, 23);
            disassembleGunButton.TabIndex = 6;
            disassembleGunButton.Text = "Disassemble Gun";
            disassembleGunButton.UseVisualStyleBackColor = true;
            disassembleGunButton.Click += disassembleGunButton_Click;
            // 
            // upgradeGunButton
            // 
            upgradeGunButton.Location = new Point(372, 208);
            upgradeGunButton.Name = "upgradeGunButton";
            upgradeGunButton.Size = new Size(120, 23);
            upgradeGunButton.TabIndex = 7;
            upgradeGunButton.Text = "Upgrade Gun";
            upgradeGunButton.UseVisualStyleBackColor = true;
            upgradeGunButton.Click += upgradeGunButton_Click;
            // 
            // partTypeComboBox
            // 
            partTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partTypeComboBox.FormattingEnabled = true;
            partTypeComboBox.Items.AddRange(new object[] { "UpperReceiver", "Barrel", "LowerReceiver", "BufferTube", "Stock", "Grip", "Trigger" });
            partTypeComboBox.Location = new Point(372, 179);
            partTypeComboBox.Name = "partTypeComboBox";
            partTypeComboBox.Size = new Size(121, 23);
            partTypeComboBox.TabIndex = 8;
            // 
            // partQualityComboBox
            // 
            partQualityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partQualityComboBox.FormattingEnabled = true;
            partQualityComboBox.Items.AddRange(new object[] { "Poor", "Standard", "Superior", "First-rate" });
            partQualityComboBox.Location = new Point(372, 238);
            partQualityComboBox.Name = "partQualityComboBox";
            partQualityComboBox.Size = new Size(121, 23);
            partQualityComboBox.TabIndex = 10;
            // 
            // gunNameTextBox
            // 
            gunNameTextBox.Location = new Point(372, 281);
            gunNameTextBox.Name = "gunNameTextBox";
            gunNameTextBox.Size = new Size(121, 23);
            gunNameTextBox.TabIndex = 9;
            // 
            // gunNameLabel
            // 
            gunNameLabel.AutoSize = true;
            gunNameLabel.BackColor = Color.Transparent;
            gunNameLabel.ForeColor = SystemColors.ButtonHighlight;
            gunNameLabel.Location = new Point(372, 263);
            gunNameLabel.Name = "gunNameLabel";
            gunNameLabel.Size = new Size(67, 15);
            gunNameLabel.TabIndex = 11;
            gunNameLabel.Text = "Gun Name:";
            // 
            // CraftingForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(584, 441);
            Controls.Add(gunNameLabel);
            Controls.Add(gunNameTextBox);
            Controls.Add(partQualityComboBox);
            Controls.Add(partTypeComboBox);
            Controls.Add(upgradeGunButton);
            Controls.Add(disassembleGunButton);
            Controls.Add(vaultGunDetailsTextBox);
            Controls.Add(characterGunDetailsTextBox);
            Controls.Add(characterGunLabel);
            Controls.Add(partsListBox);
            Controls.Add(vaultListBox);
            Controls.Add(characterListBox);
            Name = "CraftingForm";
            Text = "Crafting Form";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

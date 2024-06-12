namespace PVRL
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox characterListBox;
        private ListBox vaultGunsListBox;
        private ListBox vaultArmorsListBox;
        private Label characterGunLabel;
        private Label characterVestLabel;
        private Label characterHelmetLabel;
        private Label characterWalletLabel;
        private TextBox vaultGunDetailsTextBox;
        private TextBox vaultArmorDetailsTextBox;
        private Button equipGunButton;
        private Button equipArmorButton;
        private Button storeGunButton;
        private Button storeArmorButton;
        private Label characterLevelLabel;
        private Label characterExperienceLabel;
        private ListBox characterHealingItemsListBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            characterListBox = new ListBox();
            vaultGunsListBox = new ListBox();
            vaultArmorsListBox = new ListBox();
            characterGunLabel = new Label();
            characterVestLabel = new Label();
            characterHelmetLabel = new Label();
            characterWalletLabel = new Label();
            vaultGunDetailsTextBox = new TextBox();
            vaultArmorDetailsTextBox = new TextBox();
            equipGunButton = new Button();
            equipArmorButton = new Button();
            storeGunButton = new Button();
            storeArmorButton = new Button();
            characterLevelLabel = new Label();
            characterExperienceLabel = new Label();
            characterHealingItemsListBox = new ListBox();
            SuspendLayout();
            // 
            // characterListBox
            // 
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 15;
            characterListBox.Location = new System.Drawing.Point(12, 12);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new System.Drawing.Size(153, 94);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += new System.EventHandler(characterListBox_SelectedIndexChanged);
            // 
            // vaultGunsListBox
            // 
            vaultGunsListBox.FormattingEnabled = true;
            vaultGunsListBox.ItemHeight = 15;
            vaultGunsListBox.Location = new System.Drawing.Point(171, 12);
            vaultGunsListBox.Name = "vaultGunsListBox";
            vaultGunsListBox.Size = new System.Drawing.Size(195, 94);
            vaultGunsListBox.TabIndex = 1;
            vaultGunsListBox.SelectedIndexChanged += new System.EventHandler(vaultGunsListBox_SelectedIndexChanged);
            // 
            // vaultArmorsListBox
            // 
            vaultArmorsListBox.FormattingEnabled = true;
            vaultArmorsListBox.ItemHeight = 15;
            vaultArmorsListBox.Location = new System.Drawing.Point(372, 12);
            vaultArmorsListBox.Name = "vaultArmorsListBox";
            vaultArmorsListBox.Size = new System.Drawing.Size(195, 94);
            vaultArmorsListBox.TabIndex = 2;
            vaultArmorsListBox.SelectedIndexChanged += new System.EventHandler(vaultArmorsListBox_SelectedIndexChanged);
            // 
            // characterGunLabel
            // 
            characterGunLabel.AutoSize = true;
            characterGunLabel.BackColor = System.Drawing.Color.Transparent;
            characterGunLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterGunLabel.Location = new System.Drawing.Point(12, 120);
            characterGunLabel.Name = "characterGunLabel";
            characterGunLabel.Size = new System.Drawing.Size(101, 15);
            characterGunLabel.TabIndex = 3;
            characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterVestLabel
            // 
            characterVestLabel.AutoSize = true;
            characterVestLabel.BackColor = System.Drawing.Color.Transparent;
            characterVestLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterVestLabel.Location = new System.Drawing.Point(12, 140);
            characterVestLabel.Name = "characterVestLabel";
            characterVestLabel.Size = new System.Drawing.Size(95, 15);
            characterVestLabel.TabIndex = 4;
            characterVestLabel.Text = "No Vest Equipped";
            // 
            // characterHelmetLabel
            // 
            characterHelmetLabel.AutoSize = true;
            characterHelmetLabel.BackColor = System.Drawing.Color.Transparent;
            characterHelmetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterHelmetLabel.Location = new System.Drawing.Point(12, 160);
            characterHelmetLabel.Name = "characterHelmetLabel";
            characterHelmetLabel.Size = new System.Drawing.Size(113, 15);
            characterHelmetLabel.TabIndex = 5;
            characterHelmetLabel.Text = "No Helmet Equipped";
            // 
            // characterWalletLabel
            // 
            characterWalletLabel.AutoSize = true;
            characterWalletLabel.BackColor = System.Drawing.Color.Transparent;
            characterWalletLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterWalletLabel.Location = new System.Drawing.Point(12, 180);
            characterWalletLabel.Name = "characterWalletLabel";
            characterWalletLabel.Size = new System.Drawing.Size(46, 15);
            characterWalletLabel.TabIndex = 6;
            characterWalletLabel.Text = "Wallet: ";
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.Location = new System.Drawing.Point(171, 120);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.Size = new System.Drawing.Size(195, 276);
            vaultGunDetailsTextBox.TabIndex = 7;
            // 
            // vaultArmorDetailsTextBox
            // 
            vaultArmorDetailsTextBox.Location = new System.Drawing.Point(372, 120);
            vaultArmorDetailsTextBox.Multiline = true;
            vaultArmorDetailsTextBox.Name = "vaultArmorDetailsTextBox";
            vaultArmorDetailsTextBox.Size = new System.Drawing.Size(195, 276);
            vaultArmorDetailsTextBox.TabIndex = 8;
            // 
            // equipGunButton
            // 
            equipGunButton.Location = new System.Drawing.Point(12, 210);
            equipGunButton.Name = "equipGunButton";
            equipGunButton.Size = new System.Drawing.Size(75, 23);
            equipGunButton.TabIndex = 9;
            equipGunButton.Text = "Equip Gun";
            equipGunButton.UseVisualStyleBackColor = true;
            equipGunButton.Click += new System.EventHandler(equipGunButton_Click);
            // 
            // equipArmorButton
            // 
            equipArmorButton.Location = new System.Drawing.Point(12, 240);
            equipArmorButton.Name = "equipArmorButton";
            equipArmorButton.Size = new System.Drawing.Size(75, 23);
            equipArmorButton.TabIndex = 10;
            equipArmorButton.Text = "Equip Armor";
            equipArmorButton.UseVisualStyleBackColor = true;
            equipArmorButton.Click += new System.EventHandler(equipArmorButton_Click);
            // 
            // storeGunButton
            // 
            storeGunButton.Location = new System.Drawing.Point(93, 210);
            storeGunButton.Name = "storeGunButton";
            storeGunButton.Size = new System.Drawing.Size(72, 23);
            storeGunButton.TabIndex = 11;
            storeGunButton.Text = "Store Gun";
            storeGunButton.UseVisualStyleBackColor = true;
            storeGunButton.Click += new System.EventHandler(storeGunButton_Click);
            // 
            // storeArmorButton
            // 
            storeArmorButton.Location = new System.Drawing.Point(93, 240);
            storeArmorButton.Name = "storeArmorButton";
            storeArmorButton.Size = new System.Drawing.Size(72, 23);
            storeArmorButton.TabIndex = 12;
            storeArmorButton.Text = "Store Armor";
            storeArmorButton.UseVisualStyleBackColor = true;
            storeArmorButton.Click += new System.EventHandler(storeArmorButton_Click);
            // 
            // characterLevelLabel
            // 
            characterLevelLabel.AutoSize = true;
            characterLevelLabel.BackColor = System.Drawing.Color.Transparent;
            characterLevelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterLevelLabel.Location = new System.Drawing.Point(12, 270);
            characterLevelLabel.Name = "characterLevelLabel";
            characterLevelLabel.Size = new System.Drawing.Size(37, 15);
            characterLevelLabel.TabIndex = 13;
            characterLevelLabel.Text = "Level:";
            // 
            // characterExperienceLabel
            // 
            characterExperienceLabel.AutoSize = true;
            characterExperienceLabel.BackColor = System.Drawing.Color.Transparent;
            characterExperienceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            characterExperienceLabel.Location = new System.Drawing.Point(12, 300);
            characterExperienceLabel.Name = "characterExperienceLabel";
            characterExperienceLabel.Size = new System.Drawing.Size(67, 15);
            characterExperienceLabel.TabIndex = 14;
            characterExperienceLabel.Text = "Experience:";
            // 
            // characterHealingItemsListBox
            // 
            characterHealingItemsListBox.FormattingEnabled = true;
            characterHealingItemsListBox.ItemHeight = 15;
            characterHealingItemsListBox.Location = new System.Drawing.Point(12, 330);
            characterHealingItemsListBox.Name = "characterHealingItemsListBox";
            characterHealingItemsListBox.Size = new System.Drawing.Size(153, 94);
            characterHealingItemsListBox.TabIndex = 15;
            // 
            // InventoryForm
            // 
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            ClientSize = new System.Drawing.Size(580, 420);
            Controls.Add(characterHealingItemsListBox);
            Controls.Add(characterExperienceLabel);
            Controls.Add(characterLevelLabel);
            Controls.Add(storeArmorButton);
            Controls.Add(storeGunButton);
            Controls.Add(equipArmorButton);
            Controls.Add(equipGunButton);
            Controls.Add(vaultArmorDetailsTextBox);
            Controls.Add(vaultGunDetailsTextBox);
            Controls.Add(characterWalletLabel);
            Controls.Add(characterHelmetLabel);
            Controls.Add(characterVestLabel);
            Controls.Add(characterGunLabel);
            Controls.Add(vaultArmorsListBox);
            Controls.Add(vaultGunsListBox);
            Controls.Add(characterListBox);
            Name = "InventoryForm";
            Text = "Manage Inventory";
            Load += new System.EventHandler(InventoryForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

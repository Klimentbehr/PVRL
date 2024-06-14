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
            characterListBox.Location = new Point(12, 12);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(153, 94);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += characterListBox_SelectedIndexChanged;
            // 
            // vaultGunsListBox
            // 
            vaultGunsListBox.FormattingEnabled = true;
            vaultGunsListBox.ItemHeight = 15;
            vaultGunsListBox.Location = new Point(171, 12);
            vaultGunsListBox.Name = "vaultGunsListBox";
            vaultGunsListBox.Size = new Size(195, 94);
            vaultGunsListBox.TabIndex = 1;
            vaultGunsListBox.SelectedIndexChanged += vaultGunsListBox_SelectedIndexChanged;
            // 
            // vaultArmorsListBox
            // 
            vaultArmorsListBox.FormattingEnabled = true;
            vaultArmorsListBox.ItemHeight = 15;
            vaultArmorsListBox.Location = new Point(372, 12);
            vaultArmorsListBox.Name = "vaultArmorsListBox";
            vaultArmorsListBox.Size = new Size(195, 94);
            vaultArmorsListBox.TabIndex = 2;
            vaultArmorsListBox.SelectedIndexChanged += vaultArmorsListBox_SelectedIndexChanged;
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
            // characterVestLabel
            // 
            characterVestLabel.AutoSize = true;
            characterVestLabel.BackColor = Color.Transparent;
            characterVestLabel.ForeColor = SystemColors.ButtonHighlight;
            characterVestLabel.Location = new Point(12, 140);
            characterVestLabel.Name = "characterVestLabel";
            characterVestLabel.Size = new Size(100, 15);
            characterVestLabel.TabIndex = 4;
            characterVestLabel.Text = "No Vest Equipped";
            // 
            // characterHelmetLabel
            // 
            characterHelmetLabel.AutoSize = true;
            characterHelmetLabel.BackColor = Color.Transparent;
            characterHelmetLabel.ForeColor = SystemColors.ButtonHighlight;
            characterHelmetLabel.Location = new Point(12, 160);
            characterHelmetLabel.Name = "characterHelmetLabel";
            characterHelmetLabel.Size = new Size(118, 15);
            characterHelmetLabel.TabIndex = 5;
            characterHelmetLabel.Text = "No Helmet Equipped";
            // 
            // characterWalletLabel
            // 
            characterWalletLabel.AutoSize = true;
            characterWalletLabel.BackColor = Color.Transparent;
            characterWalletLabel.ForeColor = SystemColors.ButtonHighlight;
            characterWalletLabel.Location = new Point(12, 180);
            characterWalletLabel.Name = "characterWalletLabel";
            characterWalletLabel.Size = new Size(46, 15);
            characterWalletLabel.TabIndex = 6;
            characterWalletLabel.Text = "Wallet: ";
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.Location = new Point(171, 120);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.Size = new Size(195, 406);
            vaultGunDetailsTextBox.TabIndex = 7;
            // 
            // vaultArmorDetailsTextBox
            // 
            vaultArmorDetailsTextBox.Location = new Point(372, 120);
            vaultArmorDetailsTextBox.Multiline = true;
            vaultArmorDetailsTextBox.Name = "vaultArmorDetailsTextBox";
            vaultArmorDetailsTextBox.Size = new Size(195, 406);
            vaultArmorDetailsTextBox.TabIndex = 8;
            // 
            // equipGunButton
            // 
            equipGunButton.Location = new Point(12, 210);
            equipGunButton.Name = "equipGunButton";
            equipGunButton.Size = new Size(75, 23);
            equipGunButton.TabIndex = 9;
            equipGunButton.Text = "Equip Gun";
            equipGunButton.UseVisualStyleBackColor = true;
            equipGunButton.Click += equipGunButton_Click;
            // 
            // equipArmorButton
            // 
            equipArmorButton.Location = new Point(12, 240);
            equipArmorButton.Name = "equipArmorButton";
            equipArmorButton.Size = new Size(75, 23);
            equipArmorButton.TabIndex = 10;
            equipArmorButton.Text = "Equip Armor";
            equipArmorButton.UseVisualStyleBackColor = true;
            equipArmorButton.Click += equipArmorButton_Click;
            // 
            // storeGunButton
            // 
            storeGunButton.Location = new Point(93, 210);
            storeGunButton.Name = "storeGunButton";
            storeGunButton.Size = new Size(72, 23);
            storeGunButton.TabIndex = 11;
            storeGunButton.Text = "Store Gun";
            storeGunButton.UseVisualStyleBackColor = true;
            storeGunButton.Click += storeGunButton_Click;
            // 
            // storeArmorButton
            // 
            storeArmorButton.Location = new Point(93, 240);
            storeArmorButton.Name = "storeArmorButton";
            storeArmorButton.Size = new Size(72, 23);
            storeArmorButton.TabIndex = 12;
            storeArmorButton.Text = "Store Armor";
            storeArmorButton.UseVisualStyleBackColor = true;
            storeArmorButton.Click += storeArmorButton_Click;
            // 
            // characterLevelLabel
            // 
            characterLevelLabel.AutoSize = true;
            characterLevelLabel.BackColor = Color.Transparent;
            characterLevelLabel.ForeColor = SystemColors.ButtonHighlight;
            characterLevelLabel.Location = new Point(12, 270);
            characterLevelLabel.Name = "characterLevelLabel";
            characterLevelLabel.Size = new Size(37, 15);
            characterLevelLabel.TabIndex = 13;
            characterLevelLabel.Text = "Level:";
            // 
            // characterExperienceLabel
            // 
            characterExperienceLabel.AutoSize = true;
            characterExperienceLabel.BackColor = Color.Transparent;
            characterExperienceLabel.ForeColor = SystemColors.ButtonHighlight;
            characterExperienceLabel.Location = new Point(12, 300);
            characterExperienceLabel.Name = "characterExperienceLabel";
            characterExperienceLabel.Size = new Size(67, 15);
            characterExperienceLabel.TabIndex = 14;
            characterExperienceLabel.Text = "Experience:";
            // 
            // characterHealingItemsListBox
            // 
            characterHealingItemsListBox.FormattingEnabled = true;
            characterHealingItemsListBox.ItemHeight = 15;
            characterHealingItemsListBox.Location = new Point(12, 330);
            characterHealingItemsListBox.Name = "characterHealingItemsListBox";
            characterHealingItemsListBox.Size = new Size(153, 94);
            characterHealingItemsListBox.TabIndex = 15;
            // 
            // InventoryForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 538);
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
            Load += InventoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

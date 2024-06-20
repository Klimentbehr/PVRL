namespace PVRL
{
    partial class InventoryControl
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
        private Button closeInventoryButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
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
            closeInventoryButton = new Button();
            SuspendLayout();
            // 
            // characterListBox
            // 
            characterListBox.BackColor = Color.Beige;
            characterListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 21;
            characterListBox.Location = new Point(562, 3);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(384, 151);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += characterListBox_SelectedIndexChanged;
            // 
            // vaultGunsListBox
            // 
            vaultGunsListBox.BackColor = Color.Beige;
            vaultGunsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vaultGunsListBox.FormattingEnabled = true;
            vaultGunsListBox.ItemHeight = 21;
            vaultGunsListBox.Location = new Point(953, 3);
            vaultGunsListBox.Name = "vaultGunsListBox";
            vaultGunsListBox.Size = new Size(445, 235);
            vaultGunsListBox.TabIndex = 1;
            vaultGunsListBox.SelectedIndexChanged += vaultGunsListBox_SelectedIndexChanged;
            // 
            // vaultArmorsListBox
            // 
            vaultArmorsListBox.BackColor = Color.Beige;
            vaultArmorsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vaultArmorsListBox.FormattingEnabled = true;
            vaultArmorsListBox.ItemHeight = 21;
            vaultArmorsListBox.Location = new Point(1404, 3);
            vaultArmorsListBox.Name = "vaultArmorsListBox";
            vaultArmorsListBox.Size = new Size(445, 235);
            vaultArmorsListBox.TabIndex = 2;
            vaultArmorsListBox.SelectedIndexChanged += vaultArmorsListBox_SelectedIndexChanged;
            // 
            // characterGunLabel
            // 
            characterGunLabel.AutoSize = true;
            characterGunLabel.BackColor = Color.Transparent;
            characterGunLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterGunLabel.ForeColor = SystemColors.ButtonHighlight;
            characterGunLabel.Location = new Point(12, 5);
            characterGunLabel.Name = "characterGunLabel";
            characterGunLabel.Size = new Size(230, 37);
            characterGunLabel.TabIndex = 3;
            characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterVestLabel
            // 
            characterVestLabel.AutoSize = true;
            characterVestLabel.BackColor = Color.Transparent;
            characterVestLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterVestLabel.ForeColor = SystemColors.ButtonHighlight;
            characterVestLabel.Location = new Point(12, 42);
            characterVestLabel.Name = "characterVestLabel";
            characterVestLabel.Size = new Size(230, 37);
            characterVestLabel.TabIndex = 4;
            characterVestLabel.Text = "No Vest Equipped";
            // 
            // characterHelmetLabel
            // 
            characterHelmetLabel.AutoSize = true;
            characterHelmetLabel.BackColor = Color.Transparent;
            characterHelmetLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterHelmetLabel.ForeColor = SystemColors.ButtonHighlight;
            characterHelmetLabel.Location = new Point(12, 79);
            characterHelmetLabel.Name = "characterHelmetLabel";
            characterHelmetLabel.Size = new Size(267, 37);
            characterHelmetLabel.TabIndex = 5;
            characterHelmetLabel.Text = "No Helmet Equipped";
            // 
            // characterWalletLabel
            // 
            characterWalletLabel.AutoSize = true;
            characterWalletLabel.BackColor = Color.Transparent;
            characterWalletLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterWalletLabel.ForeColor = SystemColors.ButtonHighlight;
            characterWalletLabel.Location = new Point(12, 116);
            characterWalletLabel.Name = "characterWalletLabel";
            characterWalletLabel.Size = new Size(105, 37);
            characterWalletLabel.TabIndex = 6;
            characterWalletLabel.Text = "Wallet: ";
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.BackColor = Color.Beige;
            vaultGunDetailsTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            vaultGunDetailsTextBox.Location = new Point(953, 244);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.Size = new Size(445, 718);
            vaultGunDetailsTextBox.TabIndex = 7;
            // 
            // vaultArmorDetailsTextBox
            // 
            vaultArmorDetailsTextBox.BackColor = Color.Beige;
            vaultArmorDetailsTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            vaultArmorDetailsTextBox.Location = new Point(1404, 244);
            vaultArmorDetailsTextBox.Multiline = true;
            vaultArmorDetailsTextBox.Name = "vaultArmorDetailsTextBox";
            vaultArmorDetailsTextBox.Size = new Size(445, 718);
            vaultArmorDetailsTextBox.TabIndex = 8;
            // 
            // equipGunButton
            // 
            equipGunButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            equipGunButton.Location = new Point(562, 156);
            equipGunButton.Name = "equipGunButton";
            equipGunButton.Size = new Size(184, 82);
            equipGunButton.TabIndex = 9;
            equipGunButton.Text = "Equip Gun";
            equipGunButton.UseVisualStyleBackColor = true;
            equipGunButton.Click += equipGunButton_Click;
            // 
            // equipArmorButton
            // 
            equipArmorButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            equipArmorButton.Location = new Point(563, 244);
            equipArmorButton.Name = "equipArmorButton";
            equipArmorButton.Size = new Size(183, 82);
            equipArmorButton.TabIndex = 10;
            equipArmorButton.Text = "Equip Armor";
            equipArmorButton.UseVisualStyleBackColor = true;
            equipArmorButton.Click += equipArmorButton_Click;
            // 
            // storeGunButton
            // 
            storeGunButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            storeGunButton.Location = new Point(763, 156);
            storeGunButton.Name = "storeGunButton";
            storeGunButton.Size = new Size(183, 82);
            storeGunButton.TabIndex = 11;
            storeGunButton.Text = "Store Gun";
            storeGunButton.UseVisualStyleBackColor = true;
            storeGunButton.Click += storeGunButton_Click;
            // 
            // storeArmorButton
            // 
            storeArmorButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            storeArmorButton.Location = new Point(763, 244);
            storeArmorButton.Name = "storeArmorButton";
            storeArmorButton.Size = new Size(184, 82);
            storeArmorButton.TabIndex = 12;
            storeArmorButton.Text = "Store Armor";
            storeArmorButton.UseVisualStyleBackColor = true;
            storeArmorButton.Click += storeArmorButton_Click;
            // 
            // characterLevelLabel
            // 
            characterLevelLabel.AutoSize = true;
            characterLevelLabel.BackColor = Color.Transparent;
            characterLevelLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterLevelLabel.ForeColor = SystemColors.ButtonHighlight;
            characterLevelLabel.Location = new Point(12, 153);
            characterLevelLabel.Name = "characterLevelLabel";
            characterLevelLabel.Size = new Size(84, 37);
            characterLevelLabel.TabIndex = 13;
            characterLevelLabel.Text = "Level:";
            // 
            // characterExperienceLabel
            // 
            characterExperienceLabel.AutoSize = true;
            characterExperienceLabel.BackColor = Color.Transparent;
            characterExperienceLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            characterExperienceLabel.ForeColor = SystemColors.ButtonHighlight;
            characterExperienceLabel.Location = new Point(12, 190);
            characterExperienceLabel.Name = "characterExperienceLabel";
            characterExperienceLabel.Size = new Size(150, 37);
            characterExperienceLabel.TabIndex = 14;
            characterExperienceLabel.Text = "Experience:";
            // 
            // characterHealingItemsListBox
            // 
            characterHealingItemsListBox.BackColor = Color.Beige;
            characterHealingItemsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            characterHealingItemsListBox.FormattingEnabled = true;
            characterHealingItemsListBox.ItemHeight = 21;
            characterHealingItemsListBox.Location = new Point(562, 349);
            characterHealingItemsListBox.Name = "characterHealingItemsListBox";
            characterHealingItemsListBox.Size = new Size(385, 613);
            characterHealingItemsListBox.TabIndex = 15;
            // 
            // closeInventoryButton
            // 
            closeInventoryButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            closeInventoryButton.Location = new Point(10, 975);
            closeInventoryButton.Name = "closeInventoryButton";
            closeInventoryButton.Size = new Size(200, 50);
            closeInventoryButton.TabIndex = 16;
            closeInventoryButton.Text = "Close Inventory";
            closeInventoryButton.Click += closeInventoryButton_Click;
            // 
            // InventoryControl
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(closeInventoryButton);
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
            Name = "InventoryControl";
            Size = new Size(1877, 1033);
            Load += InventoryControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
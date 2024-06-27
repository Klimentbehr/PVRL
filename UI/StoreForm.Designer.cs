namespace PVRL
{
    partial class StoreForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomTabControl tabControl;
        private CustomTabPage tabGuns;
        private CustomTabPage tabArmor;
        private CustomTabPage tabHealingGear;
        private ListBox gunsListBox;
        private TextBox gunDetailsTextBox;
        private Button buyGunButton;
        private ListBox playerGunsListBox;
        private TextBox playerGunDetailsTextBox;
        private Button sellGunButton;
        private ListBox playerHealingItemsListBox;
        private Button buySmallHealingItemButton;
        private Button buyMediumHealingItemButton;
        private Button buyLargeHealingItemButton;
        private Button buyFirstRateHealingItemButton;
        private ListBox playerArmorsListBox;
        private TextBox armorDetailsTextBox;
        private Button buyArmorButton;
        private TextBox playerArmorDetailsTextBox;
        private Button sellArmorButton;
        private Label walletLabel;
        private ListBox armorsListBox;
        private Button closeButton;
        private ComboBox characterComboBox;
        private Label characterLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            tabControl = new CustomTabControl();
            tabGuns = new CustomTabPage();
            gunsListBox = new ListBox();
            gunDetailsTextBox = new TextBox();
            buyGunButton = new Button();
            playerGunsListBox = new ListBox();
            playerGunDetailsTextBox = new TextBox();
            sellGunButton = new Button();
            tabArmor = new CustomTabPage();
            playerArmorsListBox = new ListBox();
            armorDetailsTextBox = new TextBox();
            buyArmorButton = new Button();
            playerArmorDetailsTextBox = new TextBox();
            sellArmorButton = new Button();
            armorsListBox = new ListBox();
            tabHealingGear = new CustomTabPage();
            playerHealingItemsListBox = new ListBox();
            buySmallHealingItemButton = new Button();
            buyMediumHealingItemButton = new Button();
            buyLargeHealingItemButton = new Button();
            buyFirstRateHealingItemButton = new Button();
            walletLabel = new Label();
            closeButton = new Button();
            characterComboBox = new ComboBox();
            characterLabel = new Label();
            tabControl.SuspendLayout();
            tabGuns.SuspendLayout();
            tabArmor.SuspendLayout();
            tabHealingGear.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGuns);
            tabControl.Controls.Add(tabArmor);
            tabControl.Controls.Add(tabHealingGear);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(100, 30);
            tabControl.Location = new Point(10, 50);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1900, 950);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabGuns
            // 
            tabGuns.BackColor = SystemColors.Info;
            tabGuns.Controls.Add(gunsListBox);
            tabGuns.Controls.Add(gunDetailsTextBox);
            tabGuns.Controls.Add(buyGunButton);
            tabGuns.Controls.Add(playerGunsListBox);
            tabGuns.Controls.Add(playerGunDetailsTextBox);
            tabGuns.Controls.Add(sellGunButton);
            tabGuns.Location = new Point(4, 34);
            tabGuns.Name = "tabGuns";
            tabGuns.Padding = new Padding(3);
            tabGuns.Size = new Size(1892, 912);
            tabGuns.TabIndex = 0;
            tabGuns.Text = "Guns";
            // 
            // gunsListBox
            // 
            gunsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunsListBox.FormattingEnabled = true;
            gunsListBox.ItemHeight = 21;
            gunsListBox.SelectionMode = SelectionMode.MultiExtended;
            gunsListBox.Location = new Point(6, 6);
            gunsListBox.Name = "gunsListBox";
            gunsListBox.Size = new Size(450, 844);
            gunsListBox.TabIndex = 0;
            gunsListBox.SelectedIndexChanged += gunsListBox_SelectedIndexChanged;
            // 
            // gunDetailsTextBox
            // 
            gunDetailsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunDetailsTextBox.Location = new Point(462, 6);
            gunDetailsTextBox.Multiline = true;
            gunDetailsTextBox.Name = "gunDetailsTextBox";
            gunDetailsTextBox.ReadOnly = true;
            gunDetailsTextBox.Size = new Size(450, 850);
            gunDetailsTextBox.TabIndex = 1;
            // 
            // buyGunButton
            // 
            buyGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buyGunButton.Location = new Point(462, 870);
            buyGunButton.Name = "buyGunButton";
            buyGunButton.Size = new Size(100, 40);
            buyGunButton.TabIndex = 2;
            buyGunButton.Text = "Buy Gun";
            buyGunButton.UseVisualStyleBackColor = true;
            buyGunButton.Click += BuyGunButton_Click;
            // 
            // playerGunsListBox
            // 
            playerGunsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerGunsListBox.FormattingEnabled = true;
            playerGunsListBox.ItemHeight = 21;
            playerGunsListBox.SelectionMode = SelectionMode.MultiExtended;
            playerGunsListBox.Location = new Point(918, 6);
            playerGunsListBox.Name = "playerGunsListBox";
            playerGunsListBox.Size = new Size(450, 844);
            playerGunsListBox.TabIndex = 3;
            playerGunsListBox.SelectedIndexChanged += playerGunsListBox_SelectedIndexChanged;
            // 
            // playerGunDetailsTextBox
            // 
            playerGunDetailsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerGunDetailsTextBox.Location = new Point(1374, 6);
            playerGunDetailsTextBox.Multiline = true;
            playerGunDetailsTextBox.Name = "playerGunDetailsTextBox";
            playerGunDetailsTextBox.ReadOnly = true;
            playerGunDetailsTextBox.Size = new Size(450, 850);
            playerGunDetailsTextBox.TabIndex = 4;
            // 
            // sellGunButton
            // 
            sellGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sellGunButton.Location = new Point(1374, 870);
            sellGunButton.Name = "sellGunButton";
            sellGunButton.Size = new Size(100, 40);
            sellGunButton.TabIndex = 5;
            sellGunButton.Text = "Sell Gun";
            sellGunButton.UseVisualStyleBackColor = true;
            sellGunButton.Click += SellGunButton_Click;
            // 
            // tabArmor
            // 
            tabArmor.BackColor = SystemColors.Info;
            tabArmor.Controls.Add(playerArmorsListBox);
            tabArmor.Controls.Add(armorDetailsTextBox);
            tabArmor.Controls.Add(buyArmorButton);
            tabArmor.Controls.Add(playerArmorDetailsTextBox);
            tabArmor.Controls.Add(sellArmorButton);
            tabArmor.Controls.Add(armorsListBox);
            tabArmor.Location = new Point(4, 34);
            tabArmor.Name = "tabArmor";
            tabArmor.Padding = new Padding(3);
            tabArmor.Size = new Size(1892, 912);
            tabArmor.TabIndex = 1;
            tabArmor.Text = "Armor";
            // 
            // playerArmorsListBox
            // 
            playerArmorsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerArmorsListBox.FormattingEnabled = true;
            playerArmorsListBox.ItemHeight = 21;
            playerArmorsListBox.SelectionMode = SelectionMode.MultiExtended;
            playerArmorsListBox.Location = new Point(918, 6);
            playerArmorsListBox.Name = "playerArmorsListBox";
            playerArmorsListBox.Size = new Size(450, 844);
            playerArmorsListBox.TabIndex = 0;
            playerArmorsListBox.SelectedIndexChanged += playerArmorsListBox_SelectedIndexChanged;
            // 
            // armorDetailsTextBox
            // 
            armorDetailsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            armorDetailsTextBox.Location = new Point(462, 6);
            armorDetailsTextBox.Multiline = true;
            armorDetailsTextBox.Name = "armorDetailsTextBox";
            armorDetailsTextBox.ReadOnly = true;
            armorDetailsTextBox.Size = new Size(450, 850);
            armorDetailsTextBox.TabIndex = 1;
            // 
            // buyArmorButton
            // 
            buyArmorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buyArmorButton.Location = new Point(462, 870);
            buyArmorButton.Name = "buyArmorButton";
            buyArmorButton.Size = new Size(100, 40);
            buyArmorButton.TabIndex = 2;
            buyArmorButton.Text = "Buy Armor";
            buyArmorButton.UseVisualStyleBackColor = true;
            buyArmorButton.Click += BuyArmorButton_Click;
            // 
            // playerArmorDetailsTextBox
            // 
            playerArmorDetailsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerArmorDetailsTextBox.Location = new Point(1374, 6);
            playerArmorDetailsTextBox.Multiline = true;
            playerArmorDetailsTextBox.Name = "playerArmorDetailsTextBox";
            playerArmorDetailsTextBox.ReadOnly = true;
            playerArmorDetailsTextBox.Size = new Size(450, 850);
            playerArmorDetailsTextBox.TabIndex = 3;
            // 
            // sellArmorButton
            // 
            sellArmorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sellArmorButton.Location = new Point(1374, 870);
            sellArmorButton.Name = "sellArmorButton";
            sellArmorButton.Size = new Size(100, 40);
            sellArmorButton.TabIndex = 4;
            sellArmorButton.Text = "Sell Armor";
            sellArmorButton.UseVisualStyleBackColor = true;
            sellArmorButton.Click += SellArmorButton_Click;
            // 
            // armorsListBox
            // 
            armorsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            armorsListBox.FormattingEnabled = true;
            armorsListBox.ItemHeight = 21;
            armorsListBox.SelectionMode = SelectionMode.MultiExtended;
            armorsListBox.Location = new Point(6, 6);
            armorsListBox.Name = "armorsListBox";
            armorsListBox.Size = new Size(450, 844);
            armorsListBox.TabIndex = 5;
            armorsListBox.SelectedIndexChanged += armorsListBox_SelectedIndexChanged;
            // 
            // tabHealingGear
            // 
            tabHealingGear.BackColor = SystemColors.Info;
            tabHealingGear.Controls.Add(playerHealingItemsListBox);
            tabHealingGear.Controls.Add(buySmallHealingItemButton);
            tabHealingGear.Controls.Add(buyMediumHealingItemButton);
            tabHealingGear.Controls.Add(buyLargeHealingItemButton);
            tabHealingGear.Controls.Add(buyFirstRateHealingItemButton);
            tabHealingGear.Location = new Point(4, 34);
            tabHealingGear.Name = "tabHealingGear";
            tabHealingGear.Padding = new Padding(3);
            tabHealingGear.Size = new Size(1892, 912);
            tabHealingGear.TabIndex = 2;
            tabHealingGear.Text = "Healing/Gear";
            // 
            // playerHealingItemsListBox
            // 
            playerHealingItemsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerHealingItemsListBox.FormattingEnabled = true;
            playerHealingItemsListBox.ItemHeight = 21;
            playerHealingItemsListBox.SelectionMode = SelectionMode.MultiExtended;
            playerHealingItemsListBox.Location = new Point(6, 6);
            playerHealingItemsListBox.Name = "playerHealingItemsListBox";
            playerHealingItemsListBox.Size = new Size(450, 844);
            playerHealingItemsListBox.TabIndex = 0;
            playerHealingItemsListBox.SelectedIndexChanged += playerHealingItemsListBox_SelectedIndexChanged;
            // 
            // buySmallHealingItemButton
            // 
            buySmallHealingItemButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buySmallHealingItemButton.Location = new Point(462, 6);
            buySmallHealingItemButton.Name = "buySmallHealingItemButton";
            buySmallHealingItemButton.Size = new Size(250, 70);
            buySmallHealingItemButton.TabIndex = 1;
            buySmallHealingItemButton.Text = "Buy Poor Healing Item";
            buySmallHealingItemButton.UseVisualStyleBackColor = true;
            buySmallHealingItemButton.Click += BuySmallHealingItemButton_Click;
            // 
            // buyMediumHealingItemButton
            // 
            buyMediumHealingItemButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buyMediumHealingItemButton.Location = new Point(462, 82);
            buyMediumHealingItemButton.Name = "buyMediumHealingItemButton";
            buyMediumHealingItemButton.Size = new Size(250, 70);
            buyMediumHealingItemButton.TabIndex = 2;
            buyMediumHealingItemButton.Text = "Buy Standard Healing Item";
            buyMediumHealingItemButton.UseVisualStyleBackColor = true;
            buyMediumHealingItemButton.Click += BuyMediumHealingItemButton_Click;
            // 
            // buyLargeHealingItemButton
            // 
            buyLargeHealingItemButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buyLargeHealingItemButton.Location = new Point(462, 158);
            buyLargeHealingItemButton.Name = "buyLargeHealingItemButton";
            buyLargeHealingItemButton.Size = new Size(250, 70);
            buyLargeHealingItemButton.TabIndex = 3;
            buyLargeHealingItemButton.Text = "Buy Superior Healing Item";
            buyLargeHealingItemButton.UseVisualStyleBackColor = true;
            buyLargeHealingItemButton.Click += BuyLargeHealingItemButton_Click;
            // 
            // buyFirstRateHealingItemButton
            // 
            buyFirstRateHealingItemButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buyFirstRateHealingItemButton.Location = new Point(462, 234);
            buyFirstRateHealingItemButton.Name = "buyFirstRateHealingItemButton";
            buyFirstRateHealingItemButton.Size = new Size(250, 70);
            buyFirstRateHealingItemButton.TabIndex = 4;
            buyFirstRateHealingItemButton.Text = "Buy First-rate Healing Item";
            buyFirstRateHealingItemButton.UseVisualStyleBackColor = true;
            buyFirstRateHealingItemButton.Click += BuyFirstRateHealingItemButton_Click;
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.BackColor = Color.Transparent;
            walletLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            walletLabel.ForeColor = SystemColors.ButtonHighlight;
            walletLabel.Location = new Point(10, 1020);
            walletLabel.Name = "walletLabel";
            walletLabel.Size = new Size(105, 37);
            walletLabel.TabIndex = 1;
            walletLabel.Text = "Wallet: ";
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(1299, 1017);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(189, 51);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // characterComboBox
            // 
            characterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            characterComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterComboBox.FormattingEnabled = true;
            characterComboBox.Location = new Point(1019, 6);
            characterComboBox.Name = "characterComboBox";
            characterComboBox.Size = new Size(300, 40);
            characterComboBox.TabIndex = 3;
            characterComboBox.SelectedIndexChanged += CharacterComboBox_SelectedIndexChanged;
            // 
            // characterLabel
            // 
            characterLabel.AutoSize = true;
            characterLabel.BackColor = Color.Transparent;
            characterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterLabel.ForeColor = SystemColors.ButtonHighlight;
            characterLabel.Location = new Point(783, 9);
            characterLabel.Name = "characterLabel";
            characterLabel.Size = new Size(186, 32);
            characterLabel.TabIndex = 4;
            characterLabel.Text = "Select Character";
            // 
            // StoreForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1931, 1080);
            Controls.Add(characterLabel);
            Controls.Add(characterComboBox);
            Controls.Add(walletLabel);
            Controls.Add(closeButton);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreForm";
            Text = "Store";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabGuns.ResumeLayout(false);
            tabGuns.PerformLayout();
            tabArmor.ResumeLayout(false);
            tabArmor.PerformLayout();
            tabHealingGear.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
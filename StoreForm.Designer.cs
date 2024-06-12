namespace PVRL
{
    partial class StoreForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabGuns;
        private TabPage tabArmor;
        private TabPage tabHealingGear;
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
            tabControl = new TabControl();
            tabGuns = new TabPage();
            gunsListBox = new ListBox();
            gunDetailsTextBox = new TextBox();
            buyGunButton = new Button();
            playerGunsListBox = new ListBox();
            playerGunDetailsTextBox = new TextBox();
            sellGunButton = new Button();
            tabArmor = new TabPage();
            playerArmorsListBox = new ListBox();
            armorDetailsTextBox = new TextBox();
            buyArmorButton = new Button();
            playerArmorDetailsTextBox = new TextBox();
            sellArmorButton = new Button();
            armorsListBox = new ListBox();
            tabHealingGear = new TabPage();
            playerHealingItemsListBox = new ListBox();
            buySmallHealingItemButton = new Button();
            buyMediumHealingItemButton = new Button();
            buyLargeHealingItemButton = new Button();
            buyFirstRateHealingItemButton = new Button();
            walletLabel = new Label();
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
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(846, 426);
            tabControl.TabIndex = 0;
            // 
            // tabGuns
            // 
            tabGuns.Controls.Add(gunsListBox);
            tabGuns.Controls.Add(gunDetailsTextBox);
            tabGuns.Controls.Add(buyGunButton);
            tabGuns.Controls.Add(playerGunsListBox);
            tabGuns.Controls.Add(playerGunDetailsTextBox);
            tabGuns.Controls.Add(sellGunButton);
            tabGuns.Location = new Point(4, 24);
            tabGuns.Name = "tabGuns";
            tabGuns.Padding = new Padding(3);
            tabGuns.Size = new Size(838, 398);
            tabGuns.TabIndex = 0;
            tabGuns.Text = "Guns";
            tabGuns.UseVisualStyleBackColor = true;
            // 
            // gunsListBox
            // 
            gunsListBox.FormattingEnabled = true;
            gunsListBox.ItemHeight = 15;
            gunsListBox.Location = new Point(6, 6);
            gunsListBox.Name = "gunsListBox";
            gunsListBox.Size = new Size(200, 304);
            gunsListBox.TabIndex = 0;
            gunsListBox.SelectedIndexChanged += gunsListBox_SelectedIndexChanged;
            // 
            // gunDetailsTextBox
            // 
            gunDetailsTextBox.Location = new Point(212, 6);
            gunDetailsTextBox.Multiline = true;
            gunDetailsTextBox.Name = "gunDetailsTextBox";
            gunDetailsTextBox.ReadOnly = true;
            gunDetailsTextBox.Size = new Size(200, 304);
            gunDetailsTextBox.TabIndex = 1;
            // 
            // buyGunButton
            // 
            buyGunButton.Location = new Point(212, 316);
            buyGunButton.Name = "buyGunButton";
            buyGunButton.Size = new Size(75, 23);
            buyGunButton.TabIndex = 2;
            buyGunButton.Text = "Buy Gun";
            buyGunButton.UseVisualStyleBackColor = true;
            buyGunButton.Click += BuyGunButton_Click;
            // 
            // playerGunsListBox
            // 
            playerGunsListBox.FormattingEnabled = true;
            playerGunsListBox.ItemHeight = 15;
            playerGunsListBox.Location = new Point(418, 6);
            playerGunsListBox.Name = "playerGunsListBox";
            playerGunsListBox.Size = new Size(200, 304);
            playerGunsListBox.TabIndex = 3;
            playerGunsListBox.SelectedIndexChanged += playerGunsListBox_SelectedIndexChanged;
            // 
            // playerGunDetailsTextBox
            // 
            playerGunDetailsTextBox.Location = new Point(624, 6);
            playerGunDetailsTextBox.Multiline = true;
            playerGunDetailsTextBox.Name = "playerGunDetailsTextBox";
            playerGunDetailsTextBox.ReadOnly = true;
            playerGunDetailsTextBox.Size = new Size(200, 304);
            playerGunDetailsTextBox.TabIndex = 4;
            // 
            // sellGunButton
            // 
            sellGunButton.Location = new Point(624, 316);
            sellGunButton.Name = "sellGunButton";
            sellGunButton.Size = new Size(75, 23);
            sellGunButton.TabIndex = 5;
            sellGunButton.Text = "Sell Gun";
            sellGunButton.UseVisualStyleBackColor = true;
            sellGunButton.Click += SellGunButton_Click;
            // 
            // tabArmor
            // 
            tabArmor.Controls.Add(playerArmorsListBox);
            tabArmor.Controls.Add(armorDetailsTextBox);
            tabArmor.Controls.Add(buyArmorButton);
            tabArmor.Controls.Add(playerArmorDetailsTextBox);
            tabArmor.Controls.Add(sellArmorButton);
            tabArmor.Controls.Add(armorsListBox);
            tabArmor.Location = new Point(4, 24);
            tabArmor.Name = "tabArmor";
            tabArmor.Padding = new Padding(3);
            tabArmor.Size = new Size(768, 398);
            tabArmor.TabIndex = 1;
            tabArmor.Text = "Armor";
            tabArmor.UseVisualStyleBackColor = true;
            // 
            // playerArmorsListBox
            // 
            playerArmorsListBox.FormattingEnabled = true;
            playerArmorsListBox.ItemHeight = 15;
            playerArmorsListBox.Location = new Point(418, 6);
            playerArmorsListBox.Name = "playerArmorsListBox";
            playerArmorsListBox.Size = new Size(200, 304);
            playerArmorsListBox.TabIndex = 0;
            playerArmorsListBox.SelectedIndexChanged += playerArmorsListBox_SelectedIndexChanged;
            // 
            // armorDetailsTextBox
            // 
            armorDetailsTextBox.Location = new Point(212, 6);
            armorDetailsTextBox.Multiline = true;
            armorDetailsTextBox.Name = "armorDetailsTextBox";
            armorDetailsTextBox.ReadOnly = true;
            armorDetailsTextBox.Size = new Size(200, 304);
            armorDetailsTextBox.TabIndex = 1;
            // 
            // buyArmorButton
            // 
            buyArmorButton.Location = new Point(212, 316);
            buyArmorButton.Name = "buyArmorButton";
            buyArmorButton.Size = new Size(75, 23);
            buyArmorButton.TabIndex = 2;
            buyArmorButton.Text = "Buy Armor";
            buyArmorButton.UseVisualStyleBackColor = true;
            buyArmorButton.Click += BuyArmorButton_Click;
            // 
            // playerArmorDetailsTextBox
            // 
            playerArmorDetailsTextBox.Location = new Point(624, 6);
            playerArmorDetailsTextBox.Multiline = true;
            playerArmorDetailsTextBox.Name = "playerArmorDetailsTextBox";
            playerArmorDetailsTextBox.ReadOnly = true;
            playerArmorDetailsTextBox.Size = new Size(200, 304);
            playerArmorDetailsTextBox.TabIndex = 3;
            // 
            // sellArmorButton
            // 
            sellArmorButton.Location = new Point(624, 316);
            sellArmorButton.Name = "sellArmorButton";
            sellArmorButton.Size = new Size(75, 23);
            sellArmorButton.TabIndex = 4;
            sellArmorButton.Text = "Sell Armor";
            sellArmorButton.UseVisualStyleBackColor = true;
            sellArmorButton.Click += SellArmorButton_Click;
            // 
            // armorsListBox
            // 
            armorsListBox.FormattingEnabled = true;
            armorsListBox.ItemHeight = 15;
            armorsListBox.Location = new Point(6, 6);
            armorsListBox.Name = "armorsListBox";
            armorsListBox.Size = new Size(200, 304);
            armorsListBox.TabIndex = 5;
            armorsListBox.SelectedIndexChanged += armorsListBox_SelectedIndexChanged;
            // 
            // tabHealingGear
            // 
            tabHealingGear.Controls.Add(playerHealingItemsListBox);
            tabHealingGear.Controls.Add(buySmallHealingItemButton);
            tabHealingGear.Controls.Add(buyMediumHealingItemButton);
            tabHealingGear.Controls.Add(buyLargeHealingItemButton);
            tabHealingGear.Controls.Add(buyFirstRateHealingItemButton);
            tabHealingGear.Location = new Point(4, 24);
            tabHealingGear.Name = "tabHealingGear";
            tabHealingGear.Padding = new Padding(3);
            tabHealingGear.Size = new Size(768, 398);
            tabHealingGear.TabIndex = 2;
            tabHealingGear.Text = "Healing/Gear";
            tabHealingGear.UseVisualStyleBackColor = true;
            // 
            // playerHealingItemsListBox
            // 
            playerHealingItemsListBox.FormattingEnabled = true;
            playerHealingItemsListBox.ItemHeight = 15;
            playerHealingItemsListBox.Location = new Point(6, 6);
            playerHealingItemsListBox.Name = "playerHealingItemsListBox";
            playerHealingItemsListBox.Size = new Size(200, 304);
            playerHealingItemsListBox.TabIndex = 0;
            playerHealingItemsListBox.SelectedIndexChanged += playerHealingItemsListBox_SelectedIndexChanged;
            // 
            // buySmallHealingItemButton
            // 
            buySmallHealingItemButton.Location = new Point(212, 6);
            buySmallHealingItemButton.Name = "buySmallHealingItemButton";
            buySmallHealingItemButton.Size = new Size(150, 57);
            buySmallHealingItemButton.TabIndex = 1;
            buySmallHealingItemButton.Text = "Buy Poor Healing Item";
            buySmallHealingItemButton.UseVisualStyleBackColor = true;
            buySmallHealingItemButton.Click += BuySmallHealingItemButton_Click;
            // 
            // buyMediumHealingItemButton
            // 
            buyMediumHealingItemButton.Location = new Point(212, 69);
            buyMediumHealingItemButton.Name = "buyMediumHealingItemButton";
            buyMediumHealingItemButton.Size = new Size(150, 57);
            buyMediumHealingItemButton.TabIndex = 2;
            buyMediumHealingItemButton.Text = "Buy Standard Healing Item";
            buyMediumHealingItemButton.UseVisualStyleBackColor = true;
            buyMediumHealingItemButton.Click += BuyMediumHealingItemButton_Click;
            // 
            // buyLargeHealingItemButton
            // 
            buyLargeHealingItemButton.Location = new Point(212, 132);
            buyLargeHealingItemButton.Name = "buyLargeHealingItemButton";
            buyLargeHealingItemButton.Size = new Size(150, 57);
            buyLargeHealingItemButton.TabIndex = 3;
            buyLargeHealingItemButton.Text = "Buy Superior Healing Item";
            buyLargeHealingItemButton.UseVisualStyleBackColor = true;
            buyLargeHealingItemButton.Click += BuyLargeHealingItemButton_Click;
            // 
            // buyFirstRateHealingItemButton
            // 
            buyFirstRateHealingItemButton.Location = new Point(212, 195);
            buyFirstRateHealingItemButton.Name = "buyFirstRateHealingItemButton";
            buyFirstRateHealingItemButton.Size = new Size(150, 57);
            buyFirstRateHealingItemButton.TabIndex = 4;
            buyFirstRateHealingItemButton.Text = "Buy First-rate Healing Item";
            buyFirstRateHealingItemButton.UseVisualStyleBackColor = true;
            buyFirstRateHealingItemButton.Click += BuyFirstRateHealingItemButton_Click;
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.BackColor = Color.Transparent;
            walletLabel.ForeColor = SystemColors.ButtonHighlight;
            walletLabel.Location = new Point(12, 441);
            walletLabel.Name = "walletLabel";
            walletLabel.Size = new Size(46, 15);
            walletLabel.TabIndex = 1;
            walletLabel.Text = "Wallet: ";
            // 
            // StoreForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 473);
            Controls.Add(walletLabel);
            Controls.Add(tabControl);
            Name = "StoreForm";
            Text = "Store";
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

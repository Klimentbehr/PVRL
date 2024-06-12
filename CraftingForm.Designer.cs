namespace PVRL
{
    partial class CraftingForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage upgradeTabPage;
        private TabPage craftTabPage;
        private TabPage repairTabPage;
        private ListBox characterListBox;
        private ListBox vaultListBox;
        private ListBox partsListBox;
        private ListBox repairItemsListBox;
        private ListBox playerArmorsListBox; // Add this line
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
        private TextBox upperReceiverTextBox;
        private TextBox barrelTextBox;
        private TextBox lowerReceiverTextBox;
        private TextBox bufferTubeTextBox;
        private TextBox stockTextBox;
        private TextBox gripTextBox;
        private TextBox triggerTextBox;
        private Button craftGunButton;
        private TextBox craftedGunNameTextBox;
        private Label craftedGunNameLabel;
        private Button repairArmorButton;
        private Label repairItemsLabel;
        private Label characterArmorsLabel;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.upgradeTabPage = new System.Windows.Forms.TabPage();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.vaultListBox = new System.Windows.Forms.ListBox();
            this.characterGunLabel = new System.Windows.Forms.Label();
            this.characterGunDetailsTextBox = new System.Windows.Forms.TextBox();
            this.vaultGunDetailsTextBox = new System.Windows.Forms.TextBox();
            this.disassembleGunButton = new System.Windows.Forms.Button();
            this.upgradeGunButton = new System.Windows.Forms.Button();
            this.renameGunButton = new System.Windows.Forms.Button();
            this.partTypeComboBox = new System.Windows.Forms.ComboBox();
            this.partQualityComboBox = new System.Windows.Forms.ComboBox();
            this.gunNameTextBox = new System.Windows.Forms.TextBox();
            this.gunNameLabel = new System.Windows.Forms.Label();
            this.craftTabPage = new System.Windows.Forms.TabPage();
            this.craftedGunNameLabel = new System.Windows.Forms.Label();
            this.craftedGunNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upperReceiverTextBox = new System.Windows.Forms.TextBox();
            this.barrelTextBox = new System.Windows.Forms.TextBox();
            this.lowerReceiverTextBox = new System.Windows.Forms.TextBox();
            this.bufferTubeTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.gripTextBox = new System.Windows.Forms.TextBox();
            this.triggerTextBox = new System.Windows.Forms.TextBox();
            this.craftGunButton = new System.Windows.Forms.Button();
            this.partsListBox = new System.Windows.Forms.ListBox();
            this.repairTabPage = new System.Windows.Forms.TabPage();
            this.repairArmorButton = new System.Windows.Forms.Button();
            this.repairItemsLabel = new System.Windows.Forms.Label();
            this.characterArmorsLabel = new System.Windows.Forms.Label();
            this.repairItemsListBox = new System.Windows.Forms.ListBox();
            this.playerArmorsListBox = new System.Windows.Forms.ListBox(); // Add this line
            this.tabControl.SuspendLayout();
            this.upgradeTabPage.SuspendLayout();
            this.craftTabPage.SuspendLayout();
            this.repairTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.upgradeTabPage);
            this.tabControl.Controls.Add(this.craftTabPage);
            this.tabControl.Controls.Add(this.repairTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(560, 450);
            this.tabControl.TabIndex = 0;
            // 
            // upgradeTabPage
            // 
            this.upgradeTabPage.Controls.Add(this.characterListBox);
            this.upgradeTabPage.Controls.Add(this.vaultListBox);
            this.upgradeTabPage.Controls.Add(this.characterGunLabel);
            this.upgradeTabPage.Controls.Add(this.characterGunDetailsTextBox);
            this.upgradeTabPage.Controls.Add(this.vaultGunDetailsTextBox);
            this.upgradeTabPage.Controls.Add(this.disassembleGunButton);
            this.upgradeTabPage.Controls.Add(this.upgradeGunButton);
            this.upgradeTabPage.Controls.Add(this.renameGunButton);
            this.upgradeTabPage.Controls.Add(this.partTypeComboBox);
            this.upgradeTabPage.Controls.Add(this.partQualityComboBox);
            this.upgradeTabPage.Controls.Add(this.gunNameTextBox);
            this.upgradeTabPage.Controls.Add(this.gunNameLabel);
            this.upgradeTabPage.Location = new System.Drawing.Point(4, 24);
            this.upgradeTabPage.Name = "upgradeTabPage";
            this.upgradeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.upgradeTabPage.Size = new System.Drawing.Size(552, 422);
            this.upgradeTabPage.TabIndex = 0;
            this.upgradeTabPage.Text = "Weapon Upgrade";
            this.upgradeTabPage.UseVisualStyleBackColor = true;
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.ItemHeight = 15;
            this.characterListBox.Location = new System.Drawing.Point(6, 6);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(153, 94);
            this.characterListBox.TabIndex = 0;
            this.characterListBox.SelectedIndexChanged += new System.EventHandler(this.characterListBox_SelectedIndexChanged);
            // 
            // vaultListBox
            // 
            this.vaultListBox.FormattingEnabled = true;
            this.vaultListBox.ItemHeight = 15;
            this.vaultListBox.Location = new System.Drawing.Point(165, 6);
            this.vaultListBox.Name = "vaultListBox";
            this.vaultListBox.Size = new System.Drawing.Size(195, 94);
            this.vaultListBox.TabIndex = 1;
            this.vaultListBox.SelectedIndexChanged += new System.EventHandler(this.vaultListBox_SelectedIndexChanged);
            // 
            // characterGunLabel
            // 
            this.characterGunLabel.AutoSize = true;
            this.characterGunLabel.BackColor = System.Drawing.Color.Transparent;
            this.characterGunLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterGunLabel.Location = new System.Drawing.Point(6, 120);
            this.characterGunLabel.Name = "characterGunLabel";
            this.characterGunLabel.Size = new System.Drawing.Size(101, 15);
            this.characterGunLabel.TabIndex = 3;
            this.characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterGunDetailsTextBox
            // 
            this.characterGunDetailsTextBox.Location = new System.Drawing.Point(6, 150);
            this.characterGunDetailsTextBox.Multiline = true;
            this.characterGunDetailsTextBox.Name = "characterGunDetailsTextBox";
            this.characterGunDetailsTextBox.ReadOnly = true;
            this.characterGunDetailsTextBox.Size = new System.Drawing.Size(153, 220);
            this.characterGunDetailsTextBox.TabIndex = 4;
            // 
            // vaultGunDetailsTextBox
            // 
            this.vaultGunDetailsTextBox.Location = new System.Drawing.Point(165, 150);
            this.vaultGunDetailsTextBox.Multiline = true;
            this.vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            this.vaultGunDetailsTextBox.ReadOnly = true;
            this.vaultGunDetailsTextBox.Size = new System.Drawing.Size(195, 220);
            this.vaultGunDetailsTextBox.TabIndex = 5;
            // 
            // disassembleGunButton
            // 
            this.disassembleGunButton.Location = new System.Drawing.Point(366, 150);
            this.disassembleGunButton.Name = "disassembleGunButton";
            this.disassembleGunButton.Size = new System.Drawing.Size(120, 23);
            this.disassembleGunButton.TabIndex = 6;
            this.disassembleGunButton.Text = "Disassemble Gun";
            this.disassembleGunButton.UseVisualStyleBackColor = true;
            this.disassembleGunButton.Click += new System.EventHandler(this.disassembleGunButton_Click);
            // 
            // upgradeGunButton
            // 
            this.upgradeGunButton.Location = new System.Drawing.Point(366, 208);
            this.upgradeGunButton.Name = "upgradeGunButton";
            this.upgradeGunButton.Size = new System.Drawing.Size(120, 23);
            this.upgradeGunButton.TabIndex = 7;
            this.upgradeGunButton.Text = "Upgrade Gun";
            this.upgradeGunButton.UseVisualStyleBackColor = true;
            this.upgradeGunButton.Click += new System.EventHandler(this.upgradeGunButton_Click);
            // 
            // renameGunButton
            // 
            this.renameGunButton.Location = new System.Drawing.Point(366, 310);
            this.renameGunButton.Name = "renameGunButton";
            this.renameGunButton.Size = new System.Drawing.Size(120, 23);
            this.renameGunButton.TabIndex = 12;
            this.renameGunButton.Text = "Rename Gun";
            this.renameGunButton.UseVisualStyleBackColor = true;
            this.renameGunButton.Click += new System.EventHandler(this.renameGunButton_Click);
            // 
            // partTypeComboBox
            // 
            this.partTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partTypeComboBox.FormattingEnabled = true;
            this.partTypeComboBox.Items.AddRange(new object[] {
            "UpperReceiver",
            "Barrel",
            "LowerReceiver",
            "BufferTube",
            "Stock",
            "Grip",
            "Trigger"});
            this.partTypeComboBox.Location = new System.Drawing.Point(366, 179);
            this.partTypeComboBox.Name = "partTypeComboBox";
            this.partTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.partTypeComboBox.TabIndex = 8;
            // 
            // partQualityComboBox
            // 
            this.partQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partQualityComboBox.FormattingEnabled = true;
            this.partQualityComboBox.Items.AddRange(new object[] {
            "Poor",
            "Standard",
            "Superior",
            "First-rate"});
            this.partQualityComboBox.Location = new System.Drawing.Point(366, 238);
            this.partQualityComboBox.Name = "partQualityComboBox";
            this.partQualityComboBox.Size = new System.Drawing.Size(121, 23);
            this.partQualityComboBox.TabIndex = 10;
            // 
            // gunNameTextBox
            // 
            this.gunNameTextBox.Location = new System.Drawing.Point(366, 281);
            this.gunNameTextBox.Name = "gunNameTextBox";
            this.gunNameTextBox.Size = new System.Drawing.Size(121, 23);
            this.gunNameTextBox.TabIndex = 9;
            // 
            // gunNameLabel
            // 
            this.gunNameLabel.AutoSize = true;
            this.gunNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gunNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunNameLabel.Location = new System.Drawing.Point(366, 263);
            this.gunNameLabel.Name = "gunNameLabel";
            this.gunNameLabel.Size = new System.Drawing.Size(67, 15);
            this.gunNameLabel.TabIndex = 11;
            this.gunNameLabel.Text = "Gun Name:";
            // 
            // craftTabPage
            // 
            this.craftTabPage.Controls.Add(this.craftedGunNameLabel);
            this.craftTabPage.Controls.Add(this.craftedGunNameTextBox);
            this.craftTabPage.Controls.Add(this.label7);
            this.craftTabPage.Controls.Add(this.label6);
            this.craftTabPage.Controls.Add(this.label5);
            this.craftTabPage.Controls.Add(this.label4);
            this.craftTabPage.Controls.Add(this.label3);
            this.craftTabPage.Controls.Add(this.label2);
            this.craftTabPage.Controls.Add(this.label1);
            this.craftTabPage.Controls.Add(this.upperReceiverTextBox);
            this.craftTabPage.Controls.Add(this.barrelTextBox);
            this.craftTabPage.Controls.Add(this.lowerReceiverTextBox);
            this.craftTabPage.Controls.Add(this.bufferTubeTextBox);
            this.craftTabPage.Controls.Add(this.stockTextBox);
            this.craftTabPage.Controls.Add(this.gripTextBox);
            this.craftTabPage.Controls.Add(this.triggerTextBox);
            this.craftTabPage.Controls.Add(this.craftGunButton);
            this.craftTabPage.Controls.Add(this.partsListBox);
            this.craftTabPage.Location = new System.Drawing.Point(4, 24);
            this.craftTabPage.Name = "craftTabPage";
            this.craftTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.craftTabPage.Size = new System.Drawing.Size(552, 422);
            this.craftTabPage.TabIndex = 1;
            this.craftTabPage.Text = "Weapon Craft";
            this.craftTabPage.UseVisualStyleBackColor = true;
            // 
            // craftedGunNameLabel
            // 
            this.craftedGunNameLabel.AutoSize = true;
            this.craftedGunNameLabel.Location = new System.Drawing.Point(4, 314);
            this.craftedGunNameLabel.Name = "craftedGunNameLabel";
            this.craftedGunNameLabel.Size = new System.Drawing.Size(64, 15);
            this.craftedGunNameLabel.TabIndex = 16;
            this.craftedGunNameLabel.Text = "Gun Name";
            // 
            // craftedGunNameTextBox
            // 
            this.craftedGunNameTextBox.Location = new System.Drawing.Point(3, 332);
            this.craftedGunNameTextBox.Name = "craftedGunNameTextBox";
            this.craftedGunNameTextBox.Size = new System.Drawing.Size(187, 23);
            this.craftedGunNameTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trigger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Barrel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "LowerReceiver";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "BufferTube";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "UpperReceiver";
            // 
            // upperReceiverTextBox
            // 
            this.upperReceiverTextBox.AllowDrop = true;
            this.upperReceiverTextBox.Location = new System.Drawing.Point(4, 24);
            this.upperReceiverTextBox.Name = "upperReceiverTextBox";
            this.upperReceiverTextBox.Size = new System.Drawing.Size(187, 23);
            this.upperReceiverTextBox.TabIndex = 0;
            this.upperReceiverTextBox.Tag = "UpperReceiver";
            this.upperReceiverTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.upperReceiverTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // barrelTextBox
            // 
            this.barrelTextBox.AllowDrop = true;
            this.barrelTextBox.Location = new System.Drawing.Point(4, 68);
            this.barrelTextBox.Name = "barrelTextBox";
            this.barrelTextBox.Size = new System.Drawing.Size(187, 23);
            this.barrelTextBox.TabIndex = 1;
            this.barrelTextBox.Tag = "Barrel";
            this.barrelTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.barrelTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // lowerReceiverTextBox
            // 
            this.lowerReceiverTextBox.AllowDrop = true;
            this.lowerReceiverTextBox.Location = new System.Drawing.Point(4, 112);
            this.lowerReceiverTextBox.Name = "lowerReceiverTextBox";
            this.lowerReceiverTextBox.Size = new System.Drawing.Size(187, 23);
            this.lowerReceiverTextBox.TabIndex = 2;
            this.lowerReceiverTextBox.Tag = "LowerReceiver";
            this.lowerReceiverTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.lowerReceiverTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // bufferTubeTextBox
            // 
            this.bufferTubeTextBox.AllowDrop = true;
            this.bufferTubeTextBox.Location = new System.Drawing.Point(4, 156);
            this.bufferTubeTextBox.Name = "bufferTubeTextBox";
            this.bufferTubeTextBox.Size = new System.Drawing.Size(187, 23);
            this.bufferTubeTextBox.TabIndex = 3;
            this.bufferTubeTextBox.Tag = "BufferTube";
            this.bufferTubeTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.bufferTubeTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // stockTextBox
            // 
            this.stockTextBox.AllowDrop = true;
            this.stockTextBox.Location = new System.Drawing.Point(3, 200);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(187, 23);
            this.stockTextBox.TabIndex = 4;
            this.stockTextBox.Tag = "Stock";
            this.stockTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.stockTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // gripTextBox
            // 
            this.gripTextBox.AllowDrop = true;
            this.gripTextBox.Location = new System.Drawing.Point(3, 244);
            this.gripTextBox.Name = "gripTextBox";
            this.gripTextBox.Size = new System.Drawing.Size(187, 23);
            this.gripTextBox.TabIndex = 5;
            this.gripTextBox.Tag = "Grip";
            this.gripTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.gripTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // triggerTextBox
            // 
            this.triggerTextBox.AllowDrop = true;
            this.triggerTextBox.Location = new System.Drawing.Point(3, 288);
            this.triggerTextBox.Name = "triggerTextBox";
            this.triggerTextBox.Size = new System.Drawing.Size(187, 23);
            this.triggerTextBox.TabIndex = 6;
            this.triggerTextBox.Tag = "Trigger";
            this.triggerTextBox.TextChanged += new System.EventHandler(this.triggerTextBox_TextChanged);
            this.triggerTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.partSlot_DragDrop);
            this.triggerTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.partSlot_DragEnter);
            // 
            // craftGunButton
            // 
            this.craftGunButton.Location = new System.Drawing.Point(3, 361);
            this.craftGunButton.Name = "craftGunButton";
            this.craftGunButton.Size = new System.Drawing.Size(188, 23);
            this.craftGunButton.TabIndex = 7;
            this.craftGunButton.Text = "Craft Gun";
            this.craftGunButton.UseVisualStyleBackColor = true;
            this.craftGunButton.Click += new System.EventHandler(this.craftGunButton_Click);
            // 
            // partsListBox
            // 
            this.partsListBox.FormattingEnabled = true;
            this.partsListBox.ItemHeight = 15;
            this.partsListBox.Location = new System.Drawing.Point(325, 6);
            this.partsListBox.Name = "partsListBox";
            this.partsListBox.Size = new System.Drawing.Size(221, 319);
            this.partsListBox.TabIndex = 2;
            this.partsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.partsListBox_MouseDown);
            // 
            // repairTabPage
            // 
            this.repairTabPage.Controls.Add(this.repairArmorButton);
            this.repairTabPage.Controls.Add(this.repairItemsLabel);
            this.repairTabPage.Controls.Add(this.characterArmorsLabel);
            this.repairTabPage.Controls.Add(this.repairItemsListBox);
            this.repairTabPage.Controls.Add(this.playerArmorsListBox);
            this.repairTabPage.Location = new System.Drawing.Point(4, 24);
            this.repairTabPage.Name = "repairTabPage";
            this.repairTabPage.Size = new System.Drawing.Size(552, 422);
            this.repairTabPage.TabIndex = 2;
            this.repairTabPage.Text = "Repair";
            this.repairTabPage.UseVisualStyleBackColor = true;
            // 
            // repairArmorButton
            // 
           
            // 
            // repairItemsLabel
            // 
            this.repairItemsLabel.AutoSize = true;
            this.repairItemsLabel.Location = new System.Drawing.Point(281, 20);
            this.repairItemsLabel.Name = "repairItemsLabel";
            this.repairItemsLabel.Size = new System.Drawing.Size(69, 15);
            this.repairItemsLabel.TabIndex = 3;
            this.repairItemsLabel.Text = "Repair Items";
            // 
            // characterArmorsLabel
            // 
            this.characterArmorsLabel.AutoSize = true;
            this.characterArmorsLabel.Location = new System.Drawing.Point(7, 20);
            this.characterArmorsLabel.Name = "characterArmorsLabel";
            this.characterArmorsLabel.Size = new System.Drawing.Size(97, 15);
            this.characterArmorsLabel.TabIndex = 2;
            this.characterArmorsLabel.Text = "Character Armors";
            // 
            // repairItemsListBox
            // 
            this.repairItemsListBox.FormattingEnabled = true;
            this.repairItemsListBox.ItemHeight = 15;
            this.repairItemsListBox.Location = new System.Drawing.Point(281, 38);
            this.repairItemsListBox.Name = "repairItemsListBox";
            this.repairItemsListBox.Size = new System.Drawing.Size(263, 319);
            this.repairItemsListBox.TabIndex = 1;
            // 
            // playerArmorsListBox
            // 
            this.playerArmorsListBox.FormattingEnabled = true;
            this.playerArmorsListBox.ItemHeight = 15;
            this.playerArmorsListBox.Location = new System.Drawing.Point(7, 38);
            this.playerArmorsListBox.Name = "playerArmorsListBox";
            this.playerArmorsListBox.Size = new System.Drawing.Size(263, 319);
            this.playerArmorsListBox.TabIndex = 0;
           // this.playerArmorsListBox.SelectedIndexChanged += new System.EventHandler(this.playerArmorsListBox_SelectedIndexChanged);
            // 
            // CraftingForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 564);
            this.Controls.Add(this.tabControl);
            this.Name = "CraftingForm";
            this.Text = "Crafting Form";
            this.Load += new System.EventHandler(this.CraftingForm_Load);
            this.tabControl.ResumeLayout(false);
            this.upgradeTabPage.ResumeLayout(false);
            this.upgradeTabPage.PerformLayout();
            this.craftTabPage.ResumeLayout(false);
            this.craftTabPage.PerformLayout();
            this.repairTabPage.ResumeLayout(false);
            this.repairTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}

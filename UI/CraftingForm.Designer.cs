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
            tabControl = new TabControl();
            upgradeTabPage = new TabPage();
            characterListBox = new ListBox();
            vaultListBox = new ListBox();
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
            craftTabPage = new TabPage();
            craftedGunNameLabel = new Label();
            craftedGunNameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            upperReceiverTextBox = new TextBox();
            barrelTextBox = new TextBox();
            lowerReceiverTextBox = new TextBox();
            bufferTubeTextBox = new TextBox();
            stockTextBox = new TextBox();
            gripTextBox = new TextBox();
            triggerTextBox = new TextBox();
            craftGunButton = new Button();
            partsListBox = new ListBox();
            repairTabPage = new TabPage();
            repairArmorButton = new Button();
            repairItemsLabel = new Label();
            characterArmorsLabel = new Label();
            repairItemsListBox = new ListBox();
            playerArmorsListBox = new ListBox();
            tabControl.SuspendLayout();
            upgradeTabPage.SuspendLayout();
            craftTabPage.SuspendLayout();
            repairTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(upgradeTabPage);
            tabControl.Controls.Add(craftTabPage);
            tabControl.Controls.Add(repairTabPage);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(571, 589);
            tabControl.TabIndex = 0;
            // 
            // upgradeTabPage
            // 
            upgradeTabPage.Controls.Add(characterListBox);
            upgradeTabPage.Controls.Add(vaultListBox);
            upgradeTabPage.Controls.Add(characterGunLabel);
            upgradeTabPage.Controls.Add(characterGunDetailsTextBox);
            upgradeTabPage.Controls.Add(vaultGunDetailsTextBox);
            upgradeTabPage.Controls.Add(disassembleGunButton);
            upgradeTabPage.Controls.Add(upgradeGunButton);
            upgradeTabPage.Controls.Add(renameGunButton);
            upgradeTabPage.Controls.Add(partTypeComboBox);
            upgradeTabPage.Controls.Add(partQualityComboBox);
            upgradeTabPage.Controls.Add(gunNameTextBox);
            upgradeTabPage.Controls.Add(gunNameLabel);
            upgradeTabPage.Location = new Point(4, 24);
            upgradeTabPage.Name = "upgradeTabPage";
            upgradeTabPage.Padding = new Padding(3);
            upgradeTabPage.Size = new Size(563, 561);
            upgradeTabPage.TabIndex = 0;
            upgradeTabPage.Text = "Weapon Upgrade";
            upgradeTabPage.UseVisualStyleBackColor = true;
            // 
            // characterListBox
            // 
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 15;
            characterListBox.Location = new Point(6, 6);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(153, 94);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += characterListBox_SelectedIndexChanged;
            // 
            // vaultListBox
            // 
            vaultListBox.FormattingEnabled = true;
            vaultListBox.ItemHeight = 15;
            vaultListBox.Location = new Point(165, 6);
            vaultListBox.Name = "vaultListBox";
            vaultListBox.Size = new Size(195, 94);
            vaultListBox.TabIndex = 1;
            vaultListBox.SelectedIndexChanged += vaultListBox_SelectedIndexChanged;
            // 
            // characterGunLabel
            // 
            characterGunLabel.AutoSize = true;
            characterGunLabel.BackColor = Color.Transparent;
            characterGunLabel.ForeColor = SystemColors.ButtonHighlight;
            characterGunLabel.Location = new Point(366, 244);
            characterGunLabel.Name = "characterGunLabel";
            characterGunLabel.Size = new Size(101, 15);
            characterGunLabel.TabIndex = 3;
            characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterGunDetailsTextBox
            // 
            characterGunDetailsTextBox.Location = new Point(6, 106);
            characterGunDetailsTextBox.Multiline = true;
            characterGunDetailsTextBox.Name = "characterGunDetailsTextBox";
            characterGunDetailsTextBox.ReadOnly = true;
            characterGunDetailsTextBox.Size = new Size(153, 449);
            characterGunDetailsTextBox.TabIndex = 4;
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.Location = new Point(165, 106);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.ReadOnly = true;
            vaultGunDetailsTextBox.Size = new Size(195, 449);
            vaultGunDetailsTextBox.TabIndex = 5;
            // 
            // disassembleGunButton
            // 
            disassembleGunButton.Location = new Point(366, 5);
            disassembleGunButton.Name = "disassembleGunButton";
            disassembleGunButton.Size = new Size(120, 23);
            disassembleGunButton.TabIndex = 6;
            disassembleGunButton.Text = "Disassemble Gun";
            disassembleGunButton.UseVisualStyleBackColor = true;
            disassembleGunButton.Click += disassembleGunButton_Click;
            // 
            // upgradeGunButton
            // 
            upgradeGunButton.Location = new Point(366, 63);
            upgradeGunButton.Name = "upgradeGunButton";
            upgradeGunButton.Size = new Size(120, 23);
            upgradeGunButton.TabIndex = 7;
            upgradeGunButton.Text = "Upgrade Gun";
            upgradeGunButton.UseVisualStyleBackColor = true;
            upgradeGunButton.Click += upgradeGunButton_Click;
            // 
            // renameGunButton
            // 
            renameGunButton.Location = new Point(366, 165);
            renameGunButton.Name = "renameGunButton";
            renameGunButton.Size = new Size(120, 23);
            renameGunButton.TabIndex = 12;
            renameGunButton.Text = "Rename Gun";
            renameGunButton.UseVisualStyleBackColor = true;
            renameGunButton.Click += renameGunButton_Click;
            // 
            // partTypeComboBox
            // 
            partTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partTypeComboBox.FormattingEnabled = true;
            partTypeComboBox.Items.AddRange(new object[] { "UpperReceiver", "Barrel", "LowerReceiver", "BufferTube", "Stock", "Grip", "Trigger" });
            partTypeComboBox.Location = new Point(366, 34);
            partTypeComboBox.Name = "partTypeComboBox";
            partTypeComboBox.Size = new Size(121, 23);
            partTypeComboBox.TabIndex = 8;
            // 
            // partQualityComboBox
            // 
            partQualityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partQualityComboBox.FormattingEnabled = true;
            partQualityComboBox.Items.AddRange(new object[] { "Poor", "Standard", "Superior", "First-rate" });
            partQualityComboBox.Location = new Point(366, 93);
            partQualityComboBox.Name = "partQualityComboBox";
            partQualityComboBox.Size = new Size(121, 23);
            partQualityComboBox.TabIndex = 10;
            // 
            // gunNameTextBox
            // 
            gunNameTextBox.Location = new Point(366, 136);
            gunNameTextBox.Name = "gunNameTextBox";
            gunNameTextBox.Size = new Size(121, 23);
            gunNameTextBox.TabIndex = 9;
            // 
            // gunNameLabel
            // 
            gunNameLabel.AutoSize = true;
            gunNameLabel.BackColor = Color.Transparent;
            gunNameLabel.ForeColor = SystemColors.ButtonHighlight;
            gunNameLabel.Location = new Point(366, 273);
            gunNameLabel.Name = "gunNameLabel";
            gunNameLabel.Size = new Size(67, 15);
            gunNameLabel.TabIndex = 11;
            gunNameLabel.Text = "Gun Name:";
            // 
            // craftTabPage
            // 
            craftTabPage.Controls.Add(craftedGunNameLabel);
            craftTabPage.Controls.Add(craftedGunNameTextBox);
            craftTabPage.Controls.Add(label7);
            craftTabPage.Controls.Add(label6);
            craftTabPage.Controls.Add(label5);
            craftTabPage.Controls.Add(label4);
            craftTabPage.Controls.Add(label3);
            craftTabPage.Controls.Add(label2);
            craftTabPage.Controls.Add(label1);
            craftTabPage.Controls.Add(upperReceiverTextBox);
            craftTabPage.Controls.Add(barrelTextBox);
            craftTabPage.Controls.Add(lowerReceiverTextBox);
            craftTabPage.Controls.Add(bufferTubeTextBox);
            craftTabPage.Controls.Add(stockTextBox);
            craftTabPage.Controls.Add(gripTextBox);
            craftTabPage.Controls.Add(triggerTextBox);
            craftTabPage.Controls.Add(craftGunButton);
            craftTabPage.Controls.Add(partsListBox);
            craftTabPage.Location = new Point(4, 24);
            craftTabPage.Name = "craftTabPage";
            craftTabPage.Padding = new Padding(3);
            craftTabPage.Size = new Size(563, 561);
            craftTabPage.TabIndex = 1;
            craftTabPage.Text = "Weapon Craft";
            craftTabPage.UseVisualStyleBackColor = true;
            // 
            // craftedGunNameLabel
            // 
            craftedGunNameLabel.AutoSize = true;
            craftedGunNameLabel.Location = new Point(4, 314);
            craftedGunNameLabel.Name = "craftedGunNameLabel";
            craftedGunNameLabel.Size = new Size(64, 15);
            craftedGunNameLabel.TabIndex = 16;
            craftedGunNameLabel.Text = "Gun Name";
            // 
            // craftedGunNameTextBox
            // 
            craftedGunNameTextBox.Location = new Point(3, 332);
            craftedGunNameTextBox.Name = "craftedGunNameTextBox";
            craftedGunNameTextBox.Size = new Size(187, 23);
            craftedGunNameTextBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 270);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 14;
            label7.Text = "Trigger";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 226);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 13;
            label6.Text = "Grip";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 182);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 50);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 11;
            label4.Text = "Barrel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 10;
            label3.Text = "LowerReceiver";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 138);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 9;
            label2.Text = "BufferTube";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 8;
            label1.Text = "UpperReceiver";
            // 
            // upperReceiverTextBox
            // 
            upperReceiverTextBox.AllowDrop = true;
            upperReceiverTextBox.Location = new Point(4, 24);
            upperReceiverTextBox.Name = "upperReceiverTextBox";
            upperReceiverTextBox.Size = new Size(187, 23);
            upperReceiverTextBox.TabIndex = 0;
            upperReceiverTextBox.Tag = "UpperReceiver";
            upperReceiverTextBox.DragDrop += partSlot_DragDrop;
            upperReceiverTextBox.DragEnter += partSlot_DragEnter;
            // 
            // barrelTextBox
            // 
            barrelTextBox.AllowDrop = true;
            barrelTextBox.Location = new Point(4, 68);
            barrelTextBox.Name = "barrelTextBox";
            barrelTextBox.Size = new Size(187, 23);
            barrelTextBox.TabIndex = 1;
            barrelTextBox.Tag = "Barrel";
            barrelTextBox.DragDrop += partSlot_DragDrop;
            barrelTextBox.DragEnter += partSlot_DragEnter;
            // 
            // lowerReceiverTextBox
            // 
            lowerReceiverTextBox.AllowDrop = true;
            lowerReceiverTextBox.Location = new Point(4, 112);
            lowerReceiverTextBox.Name = "lowerReceiverTextBox";
            lowerReceiverTextBox.Size = new Size(187, 23);
            lowerReceiverTextBox.TabIndex = 2;
            lowerReceiverTextBox.Tag = "LowerReceiver";
            lowerReceiverTextBox.DragDrop += partSlot_DragDrop;
            lowerReceiverTextBox.DragEnter += partSlot_DragEnter;
            // 
            // bufferTubeTextBox
            // 
            bufferTubeTextBox.AllowDrop = true;
            bufferTubeTextBox.Location = new Point(4, 156);
            bufferTubeTextBox.Name = "bufferTubeTextBox";
            bufferTubeTextBox.Size = new Size(187, 23);
            bufferTubeTextBox.TabIndex = 3;
            bufferTubeTextBox.Tag = "BufferTube";
            bufferTubeTextBox.DragDrop += partSlot_DragDrop;
            bufferTubeTextBox.DragEnter += partSlot_DragEnter;
            // 
            // stockTextBox
            // 
            stockTextBox.AllowDrop = true;
            stockTextBox.Location = new Point(3, 200);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(187, 23);
            stockTextBox.TabIndex = 4;
            stockTextBox.Tag = "Stock";
            stockTextBox.DragDrop += partSlot_DragDrop;
            stockTextBox.DragEnter += partSlot_DragEnter;
            // 
            // gripTextBox
            // 
            gripTextBox.AllowDrop = true;
            gripTextBox.Location = new Point(3, 244);
            gripTextBox.Name = "gripTextBox";
            gripTextBox.Size = new Size(187, 23);
            gripTextBox.TabIndex = 5;
            gripTextBox.Tag = "Grip";
            gripTextBox.DragDrop += partSlot_DragDrop;
            gripTextBox.DragEnter += partSlot_DragEnter;
            // 
            // triggerTextBox
            // 
            triggerTextBox.AllowDrop = true;
            triggerTextBox.Location = new Point(3, 288);
            triggerTextBox.Name = "triggerTextBox";
            triggerTextBox.Size = new Size(187, 23);
            triggerTextBox.TabIndex = 6;
            triggerTextBox.Tag = "Trigger";
            triggerTextBox.TextChanged += triggerTextBox_TextChanged;
            triggerTextBox.DragDrop += partSlot_DragDrop;
            triggerTextBox.DragEnter += partSlot_DragEnter;
            // 
            // craftGunButton
            // 
            craftGunButton.Location = new Point(3, 361);
            craftGunButton.Name = "craftGunButton";
            craftGunButton.Size = new Size(188, 23);
            craftGunButton.TabIndex = 7;
            craftGunButton.Text = "Craft Gun";
            craftGunButton.UseVisualStyleBackColor = true;
            craftGunButton.Click += craftGunButton_Click;
            // 
            // partsListBox
            // 
            partsListBox.FormattingEnabled = true;
            partsListBox.ItemHeight = 15;
            partsListBox.Location = new Point(197, 6);
            partsListBox.Name = "partsListBox";
            partsListBox.Size = new Size(349, 544);
            partsListBox.TabIndex = 2;
            partsListBox.MouseDown += partsListBox_MouseDown;
            // 
            // repairTabPage
            // 
            repairTabPage.Controls.Add(repairArmorButton);
            repairTabPage.Controls.Add(repairItemsLabel);
            repairTabPage.Controls.Add(characterArmorsLabel);
            repairTabPage.Controls.Add(repairItemsListBox);
            repairTabPage.Controls.Add(playerArmorsListBox);
            repairTabPage.Location = new Point(4, 24);
            repairTabPage.Name = "repairTabPage";
            repairTabPage.Size = new Size(563, 561);
            repairTabPage.TabIndex = 2;
            repairTabPage.Text = "Repair";
            repairTabPage.UseVisualStyleBackColor = true;
            // 
            // repairArmorButton
            // 
            repairArmorButton.Location = new Point(0, 0);
            repairArmorButton.Name = "repairArmorButton";
            repairArmorButton.Size = new Size(75, 23);
            repairArmorButton.TabIndex = 0;
            // 
            // repairItemsLabel
            // 
            repairItemsLabel.AutoSize = true;
            repairItemsLabel.Location = new Point(281, 20);
            repairItemsLabel.Name = "repairItemsLabel";
            repairItemsLabel.Size = new Size(72, 15);
            repairItemsLabel.TabIndex = 3;
            repairItemsLabel.Text = "Repair Items";
            // 
            // characterArmorsLabel
            // 
            characterArmorsLabel.AutoSize = true;
            characterArmorsLabel.Location = new Point(7, 20);
            characterArmorsLabel.Name = "characterArmorsLabel";
            characterArmorsLabel.Size = new Size(100, 15);
            characterArmorsLabel.TabIndex = 2;
            characterArmorsLabel.Text = "Character Armors";
            // 
            // repairItemsListBox
            // 
            repairItemsListBox.FormattingEnabled = true;
            repairItemsListBox.ItemHeight = 15;
            repairItemsListBox.Location = new Point(281, 38);
            repairItemsListBox.Name = "repairItemsListBox";
            repairItemsListBox.Size = new Size(263, 319);
            repairItemsListBox.TabIndex = 1;
            // 
            // playerArmorsListBox
            // 
            playerArmorsListBox.FormattingEnabled = true;
            playerArmorsListBox.ItemHeight = 15;
            playerArmorsListBox.Location = new Point(7, 38);
            playerArmorsListBox.Name = "playerArmorsListBox";
            playerArmorsListBox.Size = new Size(263, 319);
            playerArmorsListBox.TabIndex = 0;
            // 
            // CraftingForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(610, 610);
            Controls.Add(tabControl);
            Name = "CraftingForm";
            Text = "Crafting Form";
            Load += CraftingForm_Load;
            tabControl.ResumeLayout(false);
            upgradeTabPage.ResumeLayout(false);
            upgradeTabPage.PerformLayout();
            craftTabPage.ResumeLayout(false);
            craftTabPage.PerformLayout();
            repairTabPage.ResumeLayout(false);
            repairTabPage.PerformLayout();
            ResumeLayout(false);
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

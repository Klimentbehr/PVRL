namespace PVRL
{
    partial class CraftingControl
    {
        private System.ComponentModel.IContainer components = null;
        private CustomTabControl tabControl;
        private CustomTabPage upgradeTabPage;
        private CustomTabPage craftTabPage;
        private CustomTabPage repairTabPage;
        private ListBox characterListBox;
        private ListBox vaultListBox;
        private ListBox partsListBox;
        private ListBox repairItemsListBox;
        private ListBox playerArmorsListBox;
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
        private Label repairItemsLabel;
        private Label characterArmorsLabel;
        private Button closeButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftingControl));
            tabControl = new CustomTabControl();
            upgradeTabPage = new CustomTabPage();
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
            craftTabPage = new CustomTabPage();
            craftedGunNameLabel = new Label();
            craftedGunNameTextBox = new TextBox();
            upperReceiverTextBox = new TextBox();
            barrelTextBox = new TextBox();
            lowerReceiverTextBox = new TextBox();
            bufferTubeTextBox = new TextBox();
            stockTextBox = new TextBox();
            gripTextBox = new TextBox();
            triggerTextBox = new TextBox();
            craftGunButton = new Button();
            partsListBox = new ListBox();
            repairTabPage = new CustomTabPage();
            repairItemsLabel = new Label();
            characterArmorsLabel = new Label();
            repairItemsListBox = new ListBox();
            playerArmorsListBox = new ListBox();
            closeButton = new Button();
            tabControl.SuspendLayout();
            upgradeTabPage.SuspendLayout();
            craftTabPage.SuspendLayout();
            repairTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Top;
            tabControl.Controls.Add(upgradeTabPage);
            tabControl.Controls.Add(craftTabPage);
            tabControl.Controls.Add(repairTabPage);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(100, 30);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1900, 920);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // upgradeTabPage
            // 
            upgradeTabPage.BackColor = SystemColors.Info;
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
            upgradeTabPage.Location = new Point(4, 34);
            upgradeTabPage.Name = "upgradeTabPage";
            upgradeTabPage.Padding = new Padding(3);
            upgradeTabPage.Size = new Size(1892, 882);
            upgradeTabPage.TabIndex = 0;
            upgradeTabPage.Text = "Weapon Upgrade";
            // 
            // characterListBox
            // 
            characterListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            characterListBox.FormattingEnabled = true;
            characterListBox.ItemHeight = 28;
            characterListBox.Location = new Point(20, 20);
            characterListBox.Name = "characterListBox";
            characterListBox.Size = new Size(400, 200);
            characterListBox.TabIndex = 0;
            characterListBox.SelectedIndexChanged += characterListBox_SelectedIndexChanged;
            // 
            // vaultListBox
            // 
            vaultListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            vaultListBox.FormattingEnabled = true;
            vaultListBox.ItemHeight = 28;
            vaultListBox.Location = new Point(440, 20);
            vaultListBox.Name = "vaultListBox";
            vaultListBox.Size = new Size(400, 200);
            vaultListBox.TabIndex = 1;
            vaultListBox.SelectedIndexChanged += vaultListBox_SelectedIndexChanged;
            // 
            // characterGunLabel
            // 
            characterGunLabel.AutoSize = true;
            characterGunLabel.BackColor = Color.Transparent;
            characterGunLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterGunLabel.ForeColor = SystemColors.ActiveCaptionText;
            characterGunLabel.Location = new Point(860, 20);
            characterGunLabel.Name = "characterGunLabel";
            characterGunLabel.Size = new Size(205, 32);
            characterGunLabel.TabIndex = 3;
            characterGunLabel.Text = "No Gun Equipped";
            // 
            // characterGunDetailsTextBox
            // 
            characterGunDetailsTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            characterGunDetailsTextBox.Location = new Point(20, 240);
            characterGunDetailsTextBox.Multiline = true;
            characterGunDetailsTextBox.Name = "characterGunDetailsTextBox";
            characterGunDetailsTextBox.ReadOnly = true;
            characterGunDetailsTextBox.Size = new Size(400, 600);
            characterGunDetailsTextBox.TabIndex = 4;
            // 
            // vaultGunDetailsTextBox
            // 
            vaultGunDetailsTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            vaultGunDetailsTextBox.Location = new Point(440, 240);
            vaultGunDetailsTextBox.Multiline = true;
            vaultGunDetailsTextBox.Name = "vaultGunDetailsTextBox";
            vaultGunDetailsTextBox.ReadOnly = true;
            vaultGunDetailsTextBox.Size = new Size(400, 600);
            vaultGunDetailsTextBox.TabIndex = 5;
            // 
            // disassembleGunButton
            // 
            disassembleGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            disassembleGunButton.Location = new Point(860, 70);
            disassembleGunButton.Name = "disassembleGunButton";
            disassembleGunButton.Size = new Size(180, 40);
            disassembleGunButton.TabIndex = 6;
            disassembleGunButton.Text = "Disassemble Gun";
            disassembleGunButton.UseVisualStyleBackColor = true;
            disassembleGunButton.Click += disassembleGunButton_Click;
            // 
            // upgradeGunButton
            // 
            upgradeGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            upgradeGunButton.Location = new Point(860, 120);
            upgradeGunButton.Name = "upgradeGunButton";
            upgradeGunButton.Size = new Size(180, 40);
            upgradeGunButton.TabIndex = 7;
            upgradeGunButton.Text = "Upgrade Gun";
            upgradeGunButton.UseVisualStyleBackColor = true;
            upgradeGunButton.Click += upgradeGunButton_Click;
            // 
            // renameGunButton
            // 
            renameGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            renameGunButton.Location = new Point(860, 170);
            renameGunButton.Name = "renameGunButton";
            renameGunButton.Size = new Size(180, 40);
            renameGunButton.TabIndex = 12;
            renameGunButton.Text = "Rename Gun";
            renameGunButton.UseVisualStyleBackColor = true;
            renameGunButton.Click += renameGunButton_Click;
            // 
            // partTypeComboBox
            // 
            partTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partTypeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partTypeComboBox.FormattingEnabled = true;
            partTypeComboBox.Items.AddRange(new object[] { "UpperReceiver", "Barrel", "LowerReceiver", "BufferTube", "Stock", "Grip", "Trigger" });
            partTypeComboBox.Location = new Point(860, 220);
            partTypeComboBox.Name = "partTypeComboBox";
            partTypeComboBox.Size = new Size(180, 29);
            partTypeComboBox.TabIndex = 8;
            // 
            // partQualityComboBox
            // 
            partQualityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partQualityComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partQualityComboBox.FormattingEnabled = true;
            partQualityComboBox.Items.AddRange(new object[] { "Poor", "Standard", "Superior", "First-rate" });
            partQualityComboBox.Location = new Point(860, 270);
            partQualityComboBox.Name = "partQualityComboBox";
            partQualityComboBox.Size = new Size(180, 29);
            partQualityComboBox.TabIndex = 10;
            // 
            // gunNameTextBox
            // 
            gunNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gunNameTextBox.Location = new Point(860, 320);
            gunNameTextBox.Name = "gunNameTextBox";
            gunNameTextBox.Size = new Size(180, 29);
            gunNameTextBox.TabIndex = 9;
            // 
            // gunNameLabel
            // 
            gunNameLabel.AutoSize = true;
            gunNameLabel.BackColor = Color.Transparent;
            gunNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gunNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            gunNameLabel.Location = new Point(860, 370);
            gunNameLabel.Name = "gunNameLabel";
            gunNameLabel.Size = new Size(134, 32);
            gunNameLabel.TabIndex = 11;
            gunNameLabel.Text = "Gun Name:";
            // 
            // craftTabPage
            // 
            craftTabPage.BackColor = SystemColors.Info;
            craftTabPage.Controls.Add(craftedGunNameLabel);
            craftTabPage.Controls.Add(craftedGunNameTextBox);
            craftTabPage.Controls.Add(upperReceiverTextBox);
            craftTabPage.Controls.Add(barrelTextBox);
            craftTabPage.Controls.Add(lowerReceiverTextBox);
            craftTabPage.Controls.Add(bufferTubeTextBox);
            craftTabPage.Controls.Add(stockTextBox);
            craftTabPage.Controls.Add(gripTextBox);
            craftTabPage.Controls.Add(triggerTextBox);
            craftTabPage.Controls.Add(craftGunButton);
            craftTabPage.Controls.Add(partsListBox);
            craftTabPage.Location = new Point(4, 34);
            craftTabPage.Name = "craftTabPage";
            craftTabPage.Padding = new Padding(3);
            craftTabPage.Size = new Size(1892, 882);
            craftTabPage.TabIndex = 1;
            craftTabPage.Text = "Weapon Craft";
            // 
            // craftedGunNameLabel
            // 
            craftedGunNameLabel.AutoSize = true;
            craftedGunNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            craftedGunNameLabel.Location = new Point(20, 570);
            craftedGunNameLabel.Name = "craftedGunNameLabel";
            craftedGunNameLabel.Size = new Size(85, 21);
            craftedGunNameLabel.TabIndex = 16;
            craftedGunNameLabel.Text = "Gun Name";
            // 
            // craftedGunNameTextBox
            // 
            craftedGunNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            craftedGunNameTextBox.Location = new Point(20, 600);
            craftedGunNameTextBox.Name = "craftedGunNameTextBox";
            craftedGunNameTextBox.Size = new Size(300, 29);
            craftedGunNameTextBox.TabIndex = 15;
            // 
            // upperReceiverTextBox
            // 
            upperReceiverTextBox.AllowDrop = true;
            upperReceiverTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            upperReceiverTextBox.Location = new Point(20, 40);
            upperReceiverTextBox.Name = "upperReceiverTextBox";
            upperReceiverTextBox.Size = new Size(300, 29);
            upperReceiverTextBox.TabIndex = 0;
            upperReceiverTextBox.Tag = "UpperReceiver";
            upperReceiverTextBox.DragDrop += partSlot_DragDrop;
            upperReceiverTextBox.DragEnter += partSlot_DragEnter;
            // 
            // barrelTextBox
            // 
            barrelTextBox.AllowDrop = true;
            barrelTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            barrelTextBox.Location = new Point(20, 120);
            barrelTextBox.Name = "barrelTextBox";
            barrelTextBox.Size = new Size(300, 29);
            barrelTextBox.TabIndex = 1;
            barrelTextBox.Tag = "Barrel";
            barrelTextBox.DragDrop += partSlot_DragDrop;
            barrelTextBox.DragEnter += partSlot_DragEnter;
            // 
            // lowerReceiverTextBox
            // 
            lowerReceiverTextBox.AllowDrop = true;
            lowerReceiverTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lowerReceiverTextBox.Location = new Point(20, 200);
            lowerReceiverTextBox.Name = "lowerReceiverTextBox";
            lowerReceiverTextBox.Size = new Size(300, 29);
            lowerReceiverTextBox.TabIndex = 2;
            lowerReceiverTextBox.Tag = "LowerReceiver";
            lowerReceiverTextBox.DragDrop += partSlot_DragDrop;
            lowerReceiverTextBox.DragEnter += partSlot_DragEnter;
            // 
            // bufferTubeTextBox
            // 
            bufferTubeTextBox.AllowDrop = true;
            bufferTubeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bufferTubeTextBox.Location = new Point(20, 280);
            bufferTubeTextBox.Name = "bufferTubeTextBox";
            bufferTubeTextBox.Size = new Size(300, 29);
            bufferTubeTextBox.TabIndex = 3;
            bufferTubeTextBox.Tag = "BufferTube";
            bufferTubeTextBox.DragDrop += partSlot_DragDrop;
            bufferTubeTextBox.DragEnter += partSlot_DragEnter;
            // 
            // stockTextBox
            // 
            stockTextBox.AllowDrop = true;
            stockTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stockTextBox.Location = new Point(20, 360);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(300, 29);
            stockTextBox.TabIndex = 4;
            stockTextBox.Tag = "Stock";
            stockTextBox.DragDrop += partSlot_DragDrop;
            stockTextBox.DragEnter += partSlot_DragEnter;
            // 
            // gripTextBox
            // 
            gripTextBox.AllowDrop = true;
            gripTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gripTextBox.Location = new Point(20, 440);
            gripTextBox.Name = "gripTextBox";
            gripTextBox.Size = new Size(300, 29);
            gripTextBox.TabIndex = 5;
            gripTextBox.Tag = "Grip";
            gripTextBox.DragDrop += partSlot_DragDrop;
            gripTextBox.DragEnter += partSlot_DragEnter;
            // 
            // triggerTextBox
            // 
            triggerTextBox.AllowDrop = true;
            triggerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            triggerTextBox.Location = new Point(20, 520);
            triggerTextBox.Name = "triggerTextBox";
            triggerTextBox.Size = new Size(300, 29);
            triggerTextBox.TabIndex = 6;
            triggerTextBox.Tag = "Trigger";
            triggerTextBox.TextChanged += triggerTextBox_TextChanged;
            triggerTextBox.DragDrop += partSlot_DragDrop;
            triggerTextBox.DragEnter += partSlot_DragEnter;
            // 
            // craftGunButton
            // 
            craftGunButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            craftGunButton.Location = new Point(20, 640);
            craftGunButton.Name = "craftGunButton";
            craftGunButton.Size = new Size(300, 40);
            craftGunButton.TabIndex = 7;
            craftGunButton.Text = "Craft Gun";
            craftGunButton.UseVisualStyleBackColor = true;
            craftGunButton.Click += craftGunButton_Click;
            // 
            // partsListBox
            // 
            partsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partsListBox.FormattingEnabled = true;
            partsListBox.ItemHeight = 21;
            partsListBox.Location = new Point(350, 20);
            partsListBox.Name = "partsListBox";
            partsListBox.Size = new Size(1500, 781);
            partsListBox.TabIndex = 2;
            partsListBox.MouseDown += partsListBox_MouseDown;
            // 
            // repairTabPage
            // 
            repairTabPage.BackColor = SystemColors.Info;
            repairTabPage.Controls.Add(repairItemsLabel);
            repairTabPage.Controls.Add(characterArmorsLabel);
            repairTabPage.Controls.Add(repairItemsListBox);
            repairTabPage.Controls.Add(playerArmorsListBox);
            repairTabPage.Location = new Point(4, 34);
            repairTabPage.Name = "repairTabPage";
            repairTabPage.Size = new Size(1892, 882);
            repairTabPage.TabIndex = 2;
            repairTabPage.Text = "Repair";
            // 
            // repairItemsLabel
            // 
            repairItemsLabel.AutoSize = true;
            repairItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repairItemsLabel.Location = new Point(320, 20);
            repairItemsLabel.Name = "repairItemsLabel";
            repairItemsLabel.Size = new Size(97, 21);
            repairItemsLabel.TabIndex = 3;
            repairItemsLabel.Text = "Repair Items";
            // 
            // characterArmorsLabel
            // 
            characterArmorsLabel.AutoSize = true;
            characterArmorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            characterArmorsLabel.Location = new Point(20, 20);
            characterArmorsLabel.Name = "characterArmorsLabel";
            characterArmorsLabel.Size = new Size(133, 21);
            characterArmorsLabel.TabIndex = 2;
            characterArmorsLabel.Text = "Character Armors";
            // 
            // repairItemsListBox
            // 
            repairItemsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repairItemsListBox.FormattingEnabled = true;
            repairItemsListBox.ItemHeight = 21;
            repairItemsListBox.Location = new Point(320, 50);
            repairItemsListBox.Name = "repairItemsListBox";
            repairItemsListBox.Size = new Size(1520, 739);
            repairItemsListBox.TabIndex = 1;
            // 
            // playerArmorsListBox
            // 
            playerArmorsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerArmorsListBox.FormattingEnabled = true;
            playerArmorsListBox.ItemHeight = 21;
            playerArmorsListBox.Location = new Point(20, 50);
            playerArmorsListBox.Name = "playerArmorsListBox";
            playerArmorsListBox.Size = new Size(280, 739);
            playerArmorsListBox.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(20, 960);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(150, 50);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // CraftingControl
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(tabControl);
            Controls.Add(closeButton);
            Name = "CraftingControl";
            Size = new Size(1920, 1080);
            Load += CraftingControl_Load;
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
namespace PVRL
{
    partial class ManageCharacterControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button inventoryButton;
        private Button skillsButton;
        private Button craftingButton;
        private Button storeButton;
        private Button returnHomeButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCharacterControl));
            inventoryButton = new Button();
            skillsButton = new Button();
            craftingButton = new Button();
            storeButton = new Button();
            returnHomeButton = new Button();
            SuspendLayout();
            // 
            // inventoryButton
            // 
            inventoryButton.Location = new Point(14, 14);
            inventoryButton.Margin = new Padding(4, 3, 4, 3);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(175, 62);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Manage Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += InventoryButton_Click;
            // 
            // skillsButton
            // 
            skillsButton.Location = new Point(14, 83);
            skillsButton.Margin = new Padding(4, 3, 4, 3);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(175, 62);
            skillsButton.TabIndex = 1;
            skillsButton.Text = "Manage Skills";
            skillsButton.UseVisualStyleBackColor = true;
            skillsButton.Click += SkillsButton_Click;
            // 
            // craftingButton
            // 
            craftingButton.Location = new Point(14, 152);
            craftingButton.Margin = new Padding(4, 3, 4, 3);
            craftingButton.Name = "craftingButton";
            craftingButton.Size = new Size(175, 62);
            craftingButton.TabIndex = 2;
            craftingButton.Text = "Crafting";
            craftingButton.UseVisualStyleBackColor = true;
            craftingButton.Click += CraftingButton_Click;
            // 
            // storeButton
            // 
            storeButton.Location = new Point(14, 222);
            storeButton.Margin = new Padding(4, 3, 4, 3);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(175, 62);
            storeButton.TabIndex = 3;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = true;
            storeButton.Click += StoreButton_Click;
            // 
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(14, 292);
            returnHomeButton.Margin = new Padding(4, 3, 4, 3);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(175, 62);
            returnHomeButton.TabIndex = 4;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += ReturnHomeButton_Click;
            // 
            // ManageCharacterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(storeButton);
            Controls.Add(craftingButton);
            Controls.Add(skillsButton);
            Controls.Add(inventoryButton);
            Controls.Add(returnHomeButton);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageCharacterControl";
            Size = new Size(933, 462);
            Resize += ManageCharacterControl_Resize;
            ResumeLayout(false);
        }
    }
}
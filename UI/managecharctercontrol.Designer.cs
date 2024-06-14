namespace PVRL
{
    partial class ManageCharacterControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button inventoryButton;
        private Button skillsButton;
        private Button craftingButton;
        private Button storeButton;

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
            this.inventoryButton = new Button();
            this.skillsButton = new Button();
            this.craftingButton = new Button();
            this.storeButton = new Button();

            this.SuspendLayout();

            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new Point(12, 12);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new Size(150, 54);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Manage Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new EventHandler(this.InventoryButton_Click);

            // 
            // skillsButton
            // 
            this.skillsButton.Location = new Point(12, 72);
            this.skillsButton.Name = "skillsButton";
            this.skillsButton.Size = new Size(150, 54);
            this.skillsButton.TabIndex = 1;
            this.skillsButton.Text = "Manage Skills";
            this.skillsButton.UseVisualStyleBackColor = true;
            this.skillsButton.Click += new EventHandler(this.SkillsButton_Click);

            // 
            // craftingButton
            // 
            this.craftingButton.Location = new Point(12, 132);
            this.craftingButton.Name = "craftingButton";
            this.craftingButton.Size = new Size(150, 54);
            this.craftingButton.TabIndex = 2;
            this.craftingButton.Text = "Crafting";
            this.craftingButton.UseVisualStyleBackColor = true;
            this.craftingButton.Click += new EventHandler(this.CraftingButton_Click);

            // 
            // storeButton
            // 
            this.storeButton.Location = new Point(12, 192);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new Size(150, 54);
            this.storeButton.TabIndex = 3;
            this.storeButton.Text = "Store";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new EventHandler(this.StoreButton_Click);

            // 
            // ManageCharacterControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.craftingButton);
            this.Controls.Add(this.skillsButton);
            this.Controls.Add(this.inventoryButton);
            this.Name = "ManageCharacterControl";
            this.Size = new Size(200, 260);
            this.ResumeLayout(false);
        }
    }
}

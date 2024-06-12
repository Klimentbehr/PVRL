namespace PVRL
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button characterCreationButton;
        private Button inventoryButton;
        private Button pveButton;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            characterCreationButton = new Button();
            inventoryButton = new Button();
            pveButton = new Button();
            skillsButton = new Button();
            craftingButton = new Button();
            storeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // characterCreationButton
            // 
            characterCreationButton.Location = new Point(53, 72);
            characterCreationButton.Name = "characterCreationButton";
            characterCreationButton.Size = new Size(150, 54);
            characterCreationButton.TabIndex = 0;
            characterCreationButton.Text = "Create Character";
            characterCreationButton.UseVisualStyleBackColor = true;
            characterCreationButton.Click += CharacterCreationButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.Location = new Point(53, 132);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(150, 54);
            inventoryButton.TabIndex = 1;
            inventoryButton.Text = "Manage Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += InventoryButton_Click;
            // 
            // pveButton
            // 
            pveButton.Location = new Point(53, 193);
            pveButton.Name = "pveButton";
            pveButton.Size = new Size(150, 54);
            pveButton.TabIndex = 3;
            pveButton.Text = "PvE";
            pveButton.UseVisualStyleBackColor = true;
            pveButton.Click += PveButton_Click;
            // 
            // skillsButton
            // 
            skillsButton.Location = new Point(53, 253);
            skillsButton.Name = "skillsButton";
            skillsButton.Size = new Size(150, 54);
            skillsButton.TabIndex = 4;
            skillsButton.Text = "Manage Skills";
            skillsButton.UseVisualStyleBackColor = true;
            skillsButton.Click += SkillsButton_Click;
            // 
            // craftingButton
            // 
            craftingButton.Location = new Point(53, 313);
            craftingButton.Name = "craftingButton";
            craftingButton.Size = new Size(150, 54);
            craftingButton.TabIndex = 5;
            craftingButton.Text = "Crafting";
            craftingButton.UseVisualStyleBackColor = true;
            craftingButton.Click += CraftingButton_Click;
            // 
            // storeButton
            // 
            storeButton.Location = new Point(53, 373);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(150, 54);
            storeButton.TabIndex = 6;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = true;
            storeButton.Click += StoreButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 24);
            label1.Name = "label1";
            label1.Size = new Size(92, 45);
            label1.TabIndex = 7;
            label1.Text = "PVRL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(269, 451);
            Controls.Add(label1);
            Controls.Add(pveButton);
            Controls.Add(inventoryButton);
            Controls.Add(characterCreationButton);
            Controls.Add(skillsButton);
            Controls.Add(craftingButton);
            Controls.Add(storeButton);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}

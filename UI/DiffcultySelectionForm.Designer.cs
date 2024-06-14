namespace PVRL
{
    partial class DifficultySelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button easyButton;
        private Button normalButton;
        private Button hardButton;
        private Button bossSlaughterButton; // New button

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
            this.easyButton = new Button();
            this.normalButton = new Button();
            this.hardButton = new Button();
            this.bossSlaughterButton = new Button(); // Initialize the new button
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Location = new Point(12, 12);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new Size(75, 23);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new EventHandler(this.EasyButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.Location = new Point(93, 12);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new Size(75, 23);
            this.normalButton.TabIndex = 1;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.Click += new EventHandler(this.NormalButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Location = new Point(174, 12);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new Size(75, 23);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new EventHandler(this.HardButton_Click);
            // 
            // bossSlaughterButton
            // 
            this.bossSlaughterButton.Location = new Point(255, 12); // Position the new button
            this.bossSlaughterButton.Name = "bossSlaughterButton";
            this.bossSlaughterButton.Size = new Size(100, 23);
            this.bossSlaughterButton.TabIndex = 3;
            this.bossSlaughterButton.Text = "Boss Slaughter";
            this.bossSlaughterButton.UseVisualStyleBackColor = true;
            this.bossSlaughterButton.Click += new EventHandler(this.BossSlaughterButton_Click);
            // 
            // DifficultySelectionForm
            // 
            this.ClientSize = new Size(370, 47); // Adjust the form size
            this.Controls.Add(this.bossSlaughterButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Name = "DifficultySelectionForm";
            this.Text = "Select Difficulty";
            this.ResumeLayout(false);
        }
    }
}

namespace PVRL
{
    partial class CombatForm
    {
        private System.ComponentModel.IContainer components = null;
        private ProgressBar playerHealthBar;
        private ProgressBar enemyHealthBar;
        private Label playerHealthLabel;
        private Label enemyHealthLabel;
        private Button attackButton;
        private Button itemButton;
        private Button healButton;
        private Button fleeButton;
        private TextBox combatLogTextBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatForm));
            playerHealthBar = new ProgressBar();
            enemyHealthBar = new ProgressBar();
            playerHealthLabel = new Label();
            enemyHealthLabel = new Label();
            attackButton = new Button();
            itemButton = new Button();
            healButton = new Button();
            fleeButton = new Button();
            combatLogTextBox = new TextBox();
            SuspendLayout();
            // 
            // playerHealthBar
            // 
            playerHealthBar.Location = new Point(12, 183);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(260, 23);
            playerHealthBar.TabIndex = 0;
            // 
            // enemyHealthBar
            // 
            enemyHealthBar.Location = new Point(12, 227);
            enemyHealthBar.Name = "enemyHealthBar";
            enemyHealthBar.Size = new Size(260, 23);
            enemyHealthBar.TabIndex = 1;
            // 
            // playerHealthLabel
            // 
            playerHealthLabel.AutoSize = true;
            playerHealthLabel.BackColor = Color.Transparent;
            playerHealthLabel.ForeColor = SystemColors.ButtonHighlight;
            playerHealthLabel.Location = new Point(12, 165);
            playerHealthLabel.Name = "playerHealthLabel";
            playerHealthLabel.Size = new Size(83, 15);
            playerHealthLabel.TabIndex = 2;
            playerHealthLabel.Text = "Player Health: ";
            // 
            // enemyHealthLabel
            // 
            enemyHealthLabel.AutoSize = true;
            enemyHealthLabel.BackColor = Color.Transparent;
            enemyHealthLabel.ForeColor = SystemColors.ButtonHighlight;
            enemyHealthLabel.Location = new Point(12, 209);
            enemyHealthLabel.Name = "enemyHealthLabel";
            enemyHealthLabel.Size = new Size(87, 15);
            enemyHealthLabel.TabIndex = 3;
            enemyHealthLabel.Text = "Enemy Health: ";
            // 
            // attackButton
            // 
            attackButton.Location = new Point(12, 256);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(75, 23);
            attackButton.TabIndex = 4;
            attackButton.Text = "Attack";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += AttackButton_Click;
            // 
            // itemButton
            // 
            itemButton.Location = new Point(93, 256);
            itemButton.Name = "itemButton";
            itemButton.Size = new Size(75, 23);
            itemButton.TabIndex = 5;
            itemButton.Text = "Item";
            itemButton.UseVisualStyleBackColor = true;
            // 
            // healButton
            // 
            healButton.Location = new Point(174, 256);
            healButton.Name = "healButton";
            healButton.Size = new Size(75, 23);
            healButton.TabIndex = 6;
            healButton.Text = "Heal";
            healButton.UseVisualStyleBackColor = true;
            healButton.Click += HealButton_Click;
            // 
            // fleeButton
            // 
            fleeButton.Location = new Point(255, 256);
            fleeButton.Name = "fleeButton";
            fleeButton.Size = new Size(75, 23);
            fleeButton.TabIndex = 7;
            fleeButton.Text = "Flee";
            fleeButton.UseVisualStyleBackColor = true;
            fleeButton.Click += FleeButton_Click;
            // 
            // combatLogTextBox
            // 
            combatLogTextBox.Location = new Point(12, 12);
            combatLogTextBox.Multiline = true;
            combatLogTextBox.Name = "combatLogTextBox";
            combatLogTextBox.ReadOnly = true;
            combatLogTextBox.Size = new Size(318, 150);
            combatLogTextBox.TabIndex = 8;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(415, 354);
            Controls.Add(combatLogTextBox);
            Controls.Add(fleeButton);
            Controls.Add(healButton);
            Controls.Add(itemButton);
            Controls.Add(attackButton);
            Controls.Add(enemyHealthLabel);
            Controls.Add(playerHealthLabel);
            Controls.Add(enemyHealthBar);
            Controls.Add(playerHealthBar);
            Name = "CombatForm";
            Text = "Combat";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

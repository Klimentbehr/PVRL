namespace PVRL
{
    partial class CombatForm
    {
        private System.ComponentModel.IContainer components = null;
        private ProgressBar playerHealthBar;
        private ProgressBar enemy1HealthBar;
        private ProgressBar enemy2HealthBar;
        private ProgressBar enemy3HealthBar;
        private Label playerHealthLabel;
        private Label enemy1HealthLabel;
        private Label enemy2HealthLabel;
        private Label enemy3HealthLabel;
        private Label dodgeCounterLabel;
        private Label roomCounterLabel; // Added label for room counter
        private Button attackButton;
        private Button itemButton;
        private Button healButton;
        private Button fleeButton;
        private Button dodgeButton;
        private ComboBox enemySelectionComboBox;
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
            enemy1HealthBar = new ProgressBar();
            enemy2HealthBar = new ProgressBar();
            enemy3HealthBar = new ProgressBar();
            playerHealthLabel = new Label();
            enemy1HealthLabel = new Label();
            enemy2HealthLabel = new Label();
            enemy3HealthLabel = new Label();
            dodgeCounterLabel = new Label();
            roomCounterLabel = new Label();
            attackButton = new Button();
            itemButton = new Button();
            healButton = new Button();
            fleeButton = new Button();
            dodgeButton = new Button();
            enemySelectionComboBox = new ComboBox();
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
            // enemy1HealthBar
            // 
            enemy1HealthBar.Location = new Point(12, 227);
            enemy1HealthBar.Name = "enemy1HealthBar";
            enemy1HealthBar.Size = new Size(260, 23);
            enemy1HealthBar.TabIndex = 1;
            // 
            // enemy2HealthBar
            // 
            enemy2HealthBar.Location = new Point(12, 271);
            enemy2HealthBar.Name = "enemy2HealthBar";
            enemy2HealthBar.Size = new Size(260, 23);
            enemy2HealthBar.TabIndex = 2;
            // 
            // enemy3HealthBar
            // 
            enemy3HealthBar.Location = new Point(12, 315);
            enemy3HealthBar.Name = "enemy3HealthBar";
            enemy3HealthBar.Size = new Size(260, 23);
            enemy3HealthBar.TabIndex = 3;
            // 
            // playerHealthLabel
            // 
            playerHealthLabel.AutoSize = true;
            playerHealthLabel.BackColor = Color.Transparent;
            playerHealthLabel.ForeColor = SystemColors.ButtonHighlight;
            playerHealthLabel.Location = new Point(12, 165);
            playerHealthLabel.Name = "playerHealthLabel";
            playerHealthLabel.Size = new Size(83, 15);
            playerHealthLabel.TabIndex = 4;
            playerHealthLabel.Text = "Player Health: ";
            // 
            // enemy1HealthLabel
            // 
            enemy1HealthLabel.AutoSize = true;
            enemy1HealthLabel.BackColor = Color.Transparent;
            enemy1HealthLabel.ForeColor = SystemColors.ButtonHighlight;
            enemy1HealthLabel.Location = new Point(12, 209);
            enemy1HealthLabel.Name = "enemy1HealthLabel";
            enemy1HealthLabel.Size = new Size(93, 15);
            enemy1HealthLabel.TabIndex = 5;
            enemy1HealthLabel.Text = "Enemy 1 Health:";
            // 
            // enemy2HealthLabel
            // 
            enemy2HealthLabel.AutoSize = true;
            enemy2HealthLabel.BackColor = Color.Transparent;
            enemy2HealthLabel.ForeColor = SystemColors.ButtonHighlight;
            enemy2HealthLabel.Location = new Point(12, 253);
            enemy2HealthLabel.Name = "enemy2HealthLabel";
            enemy2HealthLabel.Size = new Size(93, 15);
            enemy2HealthLabel.TabIndex = 6;
            enemy2HealthLabel.Text = "Enemy 2 Health:";
            // 
            // enemy3HealthLabel
            // 
            enemy3HealthLabel.AutoSize = true;
            enemy3HealthLabel.BackColor = Color.Transparent;
            enemy3HealthLabel.ForeColor = SystemColors.ButtonHighlight;
            enemy3HealthLabel.Location = new Point(12, 297);
            enemy3HealthLabel.Name = "enemy3HealthLabel";
            enemy3HealthLabel.Size = new Size(93, 15);
            enemy3HealthLabel.TabIndex = 7;
            enemy3HealthLabel.Text = "Enemy 3 Health:";
            // 
            // dodgeCounterLabel
            // 
            dodgeCounterLabel.AutoSize = true;
            dodgeCounterLabel.BackColor = Color.Transparent;
            dodgeCounterLabel.ForeColor = SystemColors.ButtonHighlight;
            dodgeCounterLabel.Location = new Point(290, 183);
            dodgeCounterLabel.Name = "dodgeCounterLabel";
            dodgeCounterLabel.Size = new Size(82, 15);
            dodgeCounterLabel.TabIndex = 16;
            dodgeCounterLabel.Text = "Dodges Left: 3";
            // 
            // roomCounterLabel
            // 
            roomCounterLabel.AutoSize = true;
            roomCounterLabel.BackColor = Color.Transparent;
            roomCounterLabel.ForeColor = SystemColors.ButtonHighlight;
            roomCounterLabel.Location = new Point(290, 165);
            roomCounterLabel.Name = "roomCounterLabel";
            roomCounterLabel.Size = new Size(62, 15);
            roomCounterLabel.TabIndex = 17;
            roomCounterLabel.Text = "Room: 1/5";
            // 
            // attackButton
            // 
            attackButton.Location = new Point(12, 344);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(75, 23);
            attackButton.TabIndex = 8;
            attackButton.Text = "Attack";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += AttackButton_Click;
            // 
            // itemButton
            // 
            itemButton.Location = new Point(93, 344);
            itemButton.Name = "itemButton";
            itemButton.Size = new Size(75, 23);
            itemButton.TabIndex = 9;
            itemButton.Text = "Item";
            itemButton.UseVisualStyleBackColor = true;
            // 
            // healButton
            // 
            healButton.Location = new Point(174, 344);
            healButton.Name = "healButton";
            healButton.Size = new Size(75, 23);
            healButton.TabIndex = 10;
            healButton.Text = "Heal";
            healButton.UseVisualStyleBackColor = true;
            healButton.Click += HealButton_Click;
            // 
            // fleeButton
            // 
            fleeButton.Location = new Point(255, 344);
            fleeButton.Name = "fleeButton";
            fleeButton.Size = new Size(75, 23);
            fleeButton.TabIndex = 11;
            fleeButton.Text = "Flee";
            fleeButton.UseVisualStyleBackColor = true;
            fleeButton.Click += FleeButton_Click;
            // 
            // dodgeButton
            // 
            dodgeButton.Location = new Point(336, 344);
            dodgeButton.Name = "dodgeButton";
            dodgeButton.Size = new Size(75, 23);
            dodgeButton.TabIndex = 12;
            dodgeButton.Text = "Dodge";
            dodgeButton.UseVisualStyleBackColor = true;
            dodgeButton.Click += DodgeButton_Click;
            // 
            // enemySelectionComboBox
            // 
            enemySelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            enemySelectionComboBox.FormattingEnabled = true;
            enemySelectionComboBox.Location = new Point(12, 373);
            enemySelectionComboBox.Name = "enemySelectionComboBox";
            enemySelectionComboBox.Size = new Size(260, 23);
            enemySelectionComboBox.TabIndex = 13;
            enemySelectionComboBox.SelectedIndexChanged += EnemySelectionComboBox_SelectedIndexChanged;
            // 
            // combatLogTextBox
            // 
            combatLogTextBox.Location = new Point(12, 12);
            combatLogTextBox.Multiline = true;
            combatLogTextBox.Name = "combatLogTextBox";
            combatLogTextBox.ReadOnly = true;
            combatLogTextBox.Size = new Size(399, 150);
            combatLogTextBox.TabIndex = 14;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(415, 408);
            Controls.Add(roomCounterLabel);
            Controls.Add(dodgeCounterLabel);
            Controls.Add(combatLogTextBox);
            Controls.Add(enemySelectionComboBox);
            Controls.Add(dodgeButton);
            Controls.Add(fleeButton);
            Controls.Add(healButton);
            Controls.Add(itemButton);
            Controls.Add(attackButton);
            Controls.Add(enemy3HealthLabel);
            Controls.Add(enemy2HealthLabel);
            Controls.Add(enemy1HealthLabel);
            Controls.Add(playerHealthLabel);
            Controls.Add(enemy3HealthBar);
            Controls.Add(enemy2HealthBar);
            Controls.Add(enemy1HealthBar);
            Controls.Add(playerHealthBar);
            Name = "CombatForm";
            Text = "Combat";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

namespace PVRL
{
    partial class CombatForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomTabControl tabControl;
        private CustomTabPage tabCombat;
        private ProgressBar playerHealthBar;
        private ProgressBar enemy1HealthBar;
        private ProgressBar enemy2HealthBar;
        private ProgressBar enemy3HealthBar;
        private Label playerHealthLabel;
        private Label enemy1HealthLabel;
        private Label enemy2HealthLabel;
        private Label enemy3HealthLabel;
        private Label dodgeCounterLabel;
        private Label roomCounterLabel;
        private Button attackButton;
        private Button itemButton;
        private Button healButton;
        private Button fleeButton;
        private ComboBox enemySelectionComboBox;
        private TextBox combatLogTextBox;
        private Button closeButton; // Added a close button

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
            tabControl = new CustomTabControl();
            tabCombat = new CustomTabPage();
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
            enemySelectionComboBox = new ComboBox();
            combatLogTextBox = new TextBox();
            closeButton = new Button();
            tabControl.SuspendLayout();
            tabCombat.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCombat);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(100, 30);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1900, 1000);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabCombat
            // 
            tabCombat.BackColor = SystemColors.Info;
            tabCombat.Controls.Add(playerHealthBar);
            tabCombat.Controls.Add(enemy1HealthBar);
            tabCombat.Controls.Add(enemy2HealthBar);
            tabCombat.Controls.Add(enemy3HealthBar);
            tabCombat.Controls.Add(playerHealthLabel);
            tabCombat.Controls.Add(enemy1HealthLabel);
            tabCombat.Controls.Add(enemy2HealthLabel);
            tabCombat.Controls.Add(enemy3HealthLabel);
            tabCombat.Controls.Add(dodgeCounterLabel);
            tabCombat.Controls.Add(roomCounterLabel);
            tabCombat.Controls.Add(attackButton);
            tabCombat.Controls.Add(itemButton);
            tabCombat.Controls.Add(healButton);
            tabCombat.Controls.Add(fleeButton);
            tabCombat.Controls.Add(enemySelectionComboBox);
            tabCombat.Controls.Add(combatLogTextBox);
            tabCombat.Controls.Add(closeButton);
            tabCombat.Location = new Point(4, 34);
            tabCombat.Name = "tabCombat";
            tabCombat.Padding = new Padding(3);
            tabCombat.Size = new Size(1892, 962);
            tabCombat.TabIndex = 0;
            tabCombat.Text = "Combat";
            // 
            // playerHealthBar
            // 
            playerHealthBar.Location = new Point(12, 300);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(800, 50);
            playerHealthBar.TabIndex = 0;
            // 
            // enemy1HealthBar
            // 
            enemy1HealthBar.Location = new Point(12, 400);
            enemy1HealthBar.Name = "enemy1HealthBar";
            enemy1HealthBar.Size = new Size(800, 50);
            enemy1HealthBar.TabIndex = 1;
            // 
            // enemy2HealthBar
            // 
            enemy2HealthBar.Location = new Point(12, 500);
            enemy2HealthBar.Name = "enemy2HealthBar";
            enemy2HealthBar.Size = new Size(800, 50);
            enemy2HealthBar.TabIndex = 2;
            // 
            // enemy3HealthBar
            // 
            enemy3HealthBar.Location = new Point(12, 600);
            enemy3HealthBar.Name = "enemy3HealthBar";
            enemy3HealthBar.Size = new Size(800, 50);
            enemy3HealthBar.TabIndex = 3;
            // 
            // playerHealthLabel
            // 
            playerHealthLabel.AutoSize = true;
            playerHealthLabel.BackColor = Color.Transparent;
            playerHealthLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerHealthLabel.ForeColor = Color.Black;
            playerHealthLabel.Location = new Point(12, 270);
            playerHealthLabel.Name = "playerHealthLabel";
            playerHealthLabel.Size = new Size(167, 32);
            playerHealthLabel.TabIndex = 4;
            playerHealthLabel.Text = "Player Health: ";
            // 
            // enemy1HealthLabel
            // 
            enemy1HealthLabel.AutoSize = true;
            enemy1HealthLabel.BackColor = Color.Transparent;
            enemy1HealthLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enemy1HealthLabel.ForeColor = Color.Black;
            enemy1HealthLabel.Location = new Point(12, 370);
            enemy1HealthLabel.Name = "enemy1HealthLabel";
            enemy1HealthLabel.Size = new Size(188, 32);
            enemy1HealthLabel.TabIndex = 5;
            enemy1HealthLabel.Text = "Enemy 1 Health:";
            // 
            // enemy2HealthLabel
            // 
            enemy2HealthLabel.AutoSize = true;
            enemy2HealthLabel.BackColor = Color.Transparent;
            enemy2HealthLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enemy2HealthLabel.ForeColor = Color.Black;
            enemy2HealthLabel.Location = new Point(12, 470);
            enemy2HealthLabel.Name = "enemy2HealthLabel";
            enemy2HealthLabel.Size = new Size(188, 32);
            enemy2HealthLabel.TabIndex = 6;
            enemy2HealthLabel.Text = "Enemy 2 Health:";
            // 
            // enemy3HealthLabel
            // 
            enemy3HealthLabel.AutoSize = true;
            enemy3HealthLabel.BackColor = Color.Transparent;
            enemy3HealthLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enemy3HealthLabel.ForeColor = Color.Black;
            enemy3HealthLabel.Location = new Point(12, 570);
            enemy3HealthLabel.Name = "enemy3HealthLabel";
            enemy3HealthLabel.Size = new Size(188, 32);
            enemy3HealthLabel.TabIndex = 7;
            enemy3HealthLabel.Text = "Enemy 3 Health:";
            // 
            // dodgeCounterLabel
            // 
            dodgeCounterLabel.AutoSize = true;
            dodgeCounterLabel.BackColor = Color.Transparent;
            dodgeCounterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dodgeCounterLabel.ForeColor = Color.Black;
            dodgeCounterLabel.Location = new Point(820, 300);
            dodgeCounterLabel.Name = "dodgeCounterLabel";
            dodgeCounterLabel.Size = new Size(168, 32);
            dodgeCounterLabel.TabIndex = 16;
            dodgeCounterLabel.Text = "Dodges Left: 3";
            // 
            // roomCounterLabel
            // 
            roomCounterLabel.AutoSize = true;
            roomCounterLabel.BackColor = Color.Transparent;
            roomCounterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roomCounterLabel.ForeColor = Color.Black;
            roomCounterLabel.Location = new Point(820, 270);
            roomCounterLabel.Name = "roomCounterLabel";
            roomCounterLabel.Size = new Size(123, 32);
            roomCounterLabel.TabIndex = 17;
            roomCounterLabel.Text = "Room: 1/5";
            // 
            // attackButton
            // 
            attackButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            attackButton.Location = new Point(12, 700);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(200, 50);
            attackButton.TabIndex = 8;
            attackButton.Text = "Attack";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += AttackButton_Click;
            // 
            // itemButton
            // 
            itemButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            itemButton.Location = new Point(220, 700);
            itemButton.Name = "itemButton";
            itemButton.Size = new Size(200, 50);
            itemButton.TabIndex = 9;
            itemButton.Text = "Item";
            itemButton.UseVisualStyleBackColor = true;
            // 
            // healButton
            // 
            healButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            healButton.Location = new Point(430, 700);
            healButton.Name = "healButton";
            healButton.Size = new Size(200, 50);
            healButton.TabIndex = 10;
            healButton.Text = "Heal";
            healButton.UseVisualStyleBackColor = true;
            healButton.Click += HealButton_Click;
            // 
            // fleeButton
            // 
            fleeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fleeButton.Location = new Point(640, 700);
            fleeButton.Name = "fleeButton";
            fleeButton.Size = new Size(200, 50);
            fleeButton.TabIndex = 11;
            fleeButton.Text = "Flee";
            fleeButton.UseVisualStyleBackColor = true;
            fleeButton.Click += FleeButton_Click;
            // 
            // enemySelectionComboBox
            // 
            enemySelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            enemySelectionComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enemySelectionComboBox.Location = new Point(12, 770);
            enemySelectionComboBox.Name = "enemySelectionComboBox";
            enemySelectionComboBox.Size = new Size(400, 40);
            enemySelectionComboBox.TabIndex = 13;
            enemySelectionComboBox.SelectedIndexChanged += EnemySelectionComboBox_SelectedIndexChanged;
            // 
            // combatLogTextBox
            // 
            combatLogTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            combatLogTextBox.Location = new Point(12, 12);
            combatLogTextBox.Multiline = true;
            combatLogTextBox.Name = "combatLogTextBox";
            combatLogTextBox.ReadOnly = true;
            combatLogTextBox.Size = new Size(1892, 200);
            combatLogTextBox.TabIndex = 14;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(12, 880);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(200, 50);
            closeButton.TabIndex = 18;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1080);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CombatForm";
            Text = "Combat";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabCombat.ResumeLayout(false);
            tabCombat.PerformLayout();
            ResumeLayout(false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

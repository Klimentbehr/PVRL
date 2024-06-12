using Main;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PVRL
{
    public partial class CombatForm : Form
    {
        private static bool combatFormOpen = false;
        private Character player;
        private List<Character> enemies;
        private Main.DifficultyLevel difficulty;
        private Vault vault;
        private bool playerFled = false;
        public bool PlayerWon { get; private set; } = false;

        private bool playerDodging = false;
        private int dodgeCounter;

        public CombatForm(Character player, Main.DifficultyLevel difficulty, Vault vault)
        {
            if (combatFormOpen)
            {
                MessageBox.Show("Another combat is already in progress.");
                this.Close();
                return;
            }

            InitializeComponent();
            this.player = player;
            this.difficulty = difficulty;
            this.vault = vault;
            this.enemies = new List<Character>();

            HealPlayerToFull(); // Heal the player to full health before starting combat
            dodgeCounter = player.Dexterity; // Set dodge counter based on player's Dexterity

            combatFormOpen = true;
            this.FormClosing += CombatForm_FormClosing;
            StartNewCombat();
        }

        private void HealPlayerToFull()
        {
            player.Health = player.MaxHealth;
        }

        private void StartNewCombat()
        {
            if (player.Health <= 0)
            {
                MessageBox.Show("Player is dead and cannot continue fighting.");
                combatFormOpen = false;
                this.Close();
                return;
            }

            GenerateEnemies();
            InitializeHealthBars();
            UpdateDodgeCounterLabel(); // Initialize dodge counter label
            UpdateCombatLog($"Player {player.Name} vs Enemies: {string.Join(", ", enemies.Select(e => e.Name))}");
        }

        private void GenerateEnemies()
        {
            Random random = new Random();
            int numEnemies = 1;
            switch (difficulty)
            {
                case Main.DifficultyLevel.Easy:
                    numEnemies = random.Next(1, 4); // 1 to 3 enemies, more likely to be 1
                    break;
                case Main.DifficultyLevel.Normal:
                    numEnemies = random.Next(1, 4); // 1 to 3 enemies, balanced
                    break;
                case Main.DifficultyLevel.Hard:
                    numEnemies = random.Next(2, 4); // 2 to 3 enemies
                    break;
                case Main.DifficultyLevel.BossSlaughter:
                    numEnemies = 1; // Always 1 enemy
                    break;
            }

            enemies.Clear();
            for (int i = 0; i < numEnemies; i++)
            {
                int health = random.Next(20, 41);
                int strength = random.Next(5, 10);
                string enemyName = "Enemy";
                bool isBoss = false;

                switch (difficulty)
                {
                    case Main.DifficultyLevel.Easy:
                        health = random.Next(20, 41); // Enemy health between 20 and 40
                        strength = random.Next(1, 5); // Lower strength for easy enemies
                        if (random.Next(0, 100) < 5)
                        {
                            enemyName = "Mini-Boss";
                            isBoss = true;
                        }
                        break;
                    case Main.DifficultyLevel.Normal:
                        health = random.Next(40, 100); // Enemy health between 40 and 100
                        strength = random.Next(10, 20); // Medium strength for normal enemies
                        if (random.Next(0, 100) < 15)
                        {
                            enemyName = "Mini-Boss";
                            isBoss = true;
                        }
                        break;
                    case Main.DifficultyLevel.Hard:
                        health = random.Next(100, 200); // Enemy health between 100 and 200
                        strength = random.Next(20, 50); // Higher strength for hard enemies
                        if (random.Next(0, 100) < 25)
                        {
                            enemyName = "Boss";
                            isBoss = true;
                        }
                        break;
                    case Main.DifficultyLevel.BossSlaughter:
                        health = random.Next(250, 2000); // Enemy health between 250 and 2000
                        strength = random.Next(50, 500); // Extremely high strength for Boss Slaughter enemies
                        enemyName = "Boss";
                        isBoss = true;
                        break;
                }

                // Double health and strength for bosses (excluding Boss Slaughter difficulty)
                if (isBoss && difficulty != Main.DifficultyLevel.BossSlaughter)
                {
                    health *= 2;
                    strength *= 2;
                }

                GunGeneration gunGenerator = new GunGeneration();
                GunGeneration.Gun enemyGun = gunGenerator.GenerateRandomGun(difficulty);

                var enemy = new Character
                {
                    Name = enemyName,
                    Health = health,
                    Strength = strength,
                    Gun = enemyGun,
                    Type = Character.CharacterType.EnemyMedium // Example type, can be adjusted
                };
                enemies.Add(enemy);
            }
            UpdateEnemySelectionComboBox();
        }


        private void UpdateEnemySelectionComboBox()
        {
            enemySelectionComboBox.Items.Clear();
            for (int i = 0; i < enemies.Count; i++)
            {
                enemySelectionComboBox.Items.Add($"{enemies[i].Name} ({i + 1})");
            }
            if (enemies.Count > 0)
            {
                enemySelectionComboBox.SelectedIndex = 0;
            }
        }

        private void InitializeHealthBars()
        {
            playerHealthBar.Maximum = player.MaxHealth;
            playerHealthBar.Value = player.Health;
            playerHealthLabel.Text = $"Player Health: {player.Health}/{player.MaxHealth}";

            enemy1HealthBar.Visible = enemies.Count > 0;
            enemy2HealthBar.Visible = enemies.Count > 1;
            enemy3HealthBar.Visible = enemies.Count > 2;

            enemy1HealthLabel.Visible = enemies.Count > 0;
            enemy2HealthLabel.Visible = enemies.Count > 1;
            enemy3HealthLabel.Visible = enemies.Count > 2;

            if (enemies.Count > 0)
            {
                enemy1HealthBar.Maximum = enemies[0].Health;
                enemy1HealthBar.Value = enemies[0].Health;
                enemy1HealthLabel.Text = $"{enemies[0].Name} Health: {enemies[0].Health}";
            }

            if (enemies.Count > 1)
            {
                enemy2HealthBar.Maximum = enemies[1].Health;
                enemy2HealthBar.Value = enemies[1].Health;
                enemy2HealthLabel.Text = $"{enemies[1].Name} Health: {enemies[1].Health}";
            }

            if (enemies.Count > 2)
            {
                enemy3HealthBar.Maximum = enemies[2].Health;
                enemy3HealthBar.Value = enemies[2].Health;
                enemy3HealthLabel.Text = $"{enemies[2].Name} Health: {enemies[2].Health}";
            }

            attackButton.Enabled = true;
            itemButton.Enabled = true;
            healButton.Enabled = true;
            fleeButton.Enabled = true;
            dodgeButton.Enabled = true;
        }

        private void PerformPlayerAttack()
        {
            if (enemySelectionComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an enemy to attack.");
                return;
            }

            int selectedEnemyIndex = enemySelectionComboBox.SelectedIndex;
            var selectedEnemy = enemies[selectedEnemyIndex];

            Random random = new Random();
            int hitChance = random.Next(1, 101);
            if (selectedEnemy.Dexterity * 10 >= hitChance)
            {
                UpdateCombatLog($"Player's attack missed {selectedEnemy.Name}!");
                return;
            }

            int playerDamage = CalculateDamage(player.Gun.Damage, hitChance, player.Strength);

            selectedEnemy.Health -= playerDamage;
            if (selectedEnemy.Health < 0) selectedEnemy.Health = 0;

            UpdateHealthBars();
            UpdateCombatLog($"Player attacks {selectedEnemy.Name} for {playerDamage} damage.");

            CheckCombatEnd();
            EnemyActions();
        }

        private void PerformPlayerHeal()
        {
            var healingItems = player.HealingItems;
            if (healingItems.Count == 0)
            {
                MessageBox.Show("You have no healing items!");
                return;
            }

            HealingItemSelectionForm healingForm = new HealingItemSelectionForm(healingItems);
            if (healingForm.ShowDialog() == DialogResult.OK)
            {
                var selectedHealingItem = healingForm.SelectedHealingItem;
                int healAmount = selectedHealingItem.HealAmount;

                // Apply intelligence modifier to heal amount
                double intelligenceModifier = 1 + (player.Intelligence * 0.025);
                healAmount = (int)(healAmount * intelligenceModifier);

                player.Health += healAmount;

                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth; // Ensure health doesn't exceed max health
                }

                player.HealingItems.Remove(selectedHealingItem); // Remove used healing item
                UpdateHealthBars();
                UpdateCombatLog($"Player uses {selectedHealingItem.Name} and heals for {healAmount} health.");
                CheckCombatEnd();
            }
            EnemyActions();
        }


        private void PerformPlayerFlee()
        {
            Random random = new Random();
            int fleeChance = player.Dexterity * 10; // Assuming each point in Dexterity gives a 10% chance to flee
            int roll = random.Next(1, 101); // Roll a number between 1 and 100

            if (roll <= fleeChance)
            {
                MessageBox.Show("You successfully fled the combat!");
                playerFled = true;
                combatFormOpen = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Flee attempt failed!");
                EnemyFreeAttack();
            }
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            PerformPlayerAttack();
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            PerformPlayerHeal();
        }

        private void FleeButton_Click(object sender, EventArgs e)
        {
            PerformPlayerFlee();
        }

        private void DodgeButton_Click(object sender, EventArgs e)
        {
            PerformPlayerDodge();
        }

        private void PerformPlayerDodge()
        {
            if (dodgeCounter > 0)
            {
                playerDodging = true;
                dodgeCounter--;
                UpdateDodgeCounterLabel();
                UpdateCombatLog("Player is attempting to dodge the next attack.");
            }
            else
            {
                MessageBox.Show("You have no dodges left!");
            }
            EnemyActions(); // Execute enemy actions right after the player dodges
        }

        private void EnemyActions()
        {
            Random random = new Random();
            foreach (var enemy in enemies.Where(e => e.Health > 0))
            {
                int hitChance = random.Next(1, 101);
                if (playerDodging && player.Dexterity * 10 >= hitChance)
                {
                    UpdateCombatLog($"{enemy.Name} missed the player!");
                    continue;
                }

                int enemyDamage = CalculateDamage(enemy.Strength, hitChance);

                // Reduce the armor durability
                //ReduceArmorDurability(player);

                player.Health -= Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player)); // Subtracting armor defense
                if (player.Health < 0) player.Health = 0;

                UpdateHealthBars();
                UpdateCombatLog($"{enemy.Name} attacks player for {enemyDamage} damage (reduced by armor to {Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player))}).");
                CheckCombatEnd();
            }

            playerDodging = false; // Reset dodging state after enemy actions
        }

       

        private void UpdateHealthBars()
        {
            playerHealthBar.Value = player.Health;
            playerHealthLabel.Text = $"Player Health: {player.Health}/{player.MaxHealth}";

            if (enemies.Count > 0)
            {
                enemy1HealthBar.Maximum = enemies[0].Health;
                enemy1HealthBar.Value = enemies[0].Health;
                enemy1HealthLabel.Text = $"{enemies[0].Name} Health: {enemies[0].Health}";
            }

            if (enemies.Count > 1)
            {
                enemy2HealthBar.Maximum = enemies[1].Health;
                enemy2HealthBar.Value = enemies[1].Health;
                enemy2HealthLabel.Text = $"{enemies[1].Name} Health: {enemies[1].Health}";
            }

            if (enemies.Count > 2)
            {
                enemy3HealthBar.Maximum = enemies[2].Health;
                enemy3HealthBar.Value = enemies[2].Health;
                enemy3HealthLabel.Text = $"{enemies[2].Name} Health: {enemies[2].Health}";
            }
        }

        private int CalculateTotalArmorDefense(Character character)
        {
            int totalDefense = 0;
            foreach (var armor in character.Armors)
            {
                totalDefense += armor.Defense;
            }
            return totalDefense;
        }

        private int CalculateDamage(int baseDamage, int hitChance, int strength = 0)
        {
            double strengthModifier = 1 + (strength * 0.025); // Each point in strength gives a 2.5% increase
            int modifiedDamage = (int)(baseDamage * strengthModifier);

            if (hitChance <= 20)
            {
                return (int)(modifiedDamage * 0.5); // Grazing hit
            }
            else if (hitChance <= 80)
            {
                return modifiedDamage; // Normal hit
            }
            else
            {
                return modifiedDamage * 2; // Smashing hit
            }
        }

        private void EnemyFreeAttack()
        {
            Random random = new Random();
            int hitChance = random.Next(1, 101);
            int enemyDamage = CalculateDamage(enemies[0].Strength, hitChance);

            // Reduce the armor durability
            //ReduceArmorDurability(player);

            player.Health -= Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player)); // Subtracting armor defense
            if (player.Health < 0) player.Health = 0;

            UpdateHealthBars();
            UpdateCombatLog($"{enemies[0].Name} attacks player for {enemyDamage} damage (reduced by armor to {Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player))}) during flee attempt.");
            CheckCombatEnd();
        }

        private void CheckCombatEnd()
        {
            if (player.Health <= 0)
            {
                UpdateCombatLog("Player has been defeated!");
                HandlePlayerDeath();
                EndCombat();
                this.Close(); // Close the form if the player is defeated
            }
            else if (enemies.All(e => e.Health <= 0))
            {
                UpdateCombatLog("All enemies have been defeated!");
                PlayerWon = true;
                HandleLoot();
                StartNewCombat(); // Start a new combat round after handling loot
            }
        }

        private void HandlePlayerDeath()
        {
            if (player.Gun != null)
            {
                vault.AddGun(player.Gun); // Add the player's gun to the vault
                UpdateCombatLog($"Player lost the gun: {player.Gun.Name}");
                player.Gun = null; // Remove the gun from the player
            }
            SaveCharacter(player); // Save the player's updated state
        }

        private void EndCombat()
        {
            attackButton.Enabled = false;
            itemButton.Enabled = false;
            healButton.Enabled = false;
            fleeButton.Enabled = false;
            dodgeButton.Enabled = false;
            combatFormOpen = false;
        }

        private void HandleLoot()
        {
            Random random = new Random();
            int gunDropChance = difficulty == Main.DifficultyLevel.Easy ? 5 : (difficulty == Main.DifficultyLevel.Normal ? 15 : (difficulty == Main.DifficultyLevel.Hard ? 50 : 100));

            foreach (var enemy in enemies)
            {
                if (enemy.Gun != null && (random.Next(0, 100) < gunDropChance || difficulty == Main.DifficultyLevel.BossSlaughter))
                {
                    vault.AddGun(enemy.Gun);
                    UpdateCombatLog($"{enemy.Name} dropped a weapon!");
                }
            }

            int moneyLooted = random.Next(difficulty == Main.DifficultyLevel.Easy ? 1 : (difficulty == Main.DifficultyLevel.Normal ? 2 : (difficulty == Main.DifficultyLevel.Hard ? 3 : 4)),
                                          difficulty == Main.DifficultyLevel.Easy ? 6 : (difficulty == Main.DifficultyLevel.Normal ? 11 : (difficulty == Main.DifficultyLevel.Hard ? 16 : 21))); // Adjusted credit payout based on difficulty
            player.Wallet += moneyLooted;
            UpdateCombatLog($"Player loots {moneyLooted} credits.");

            int xpGained = CalculateExperiencePoints(difficulty, enemies.Sum(e => e.Strength));
            player.GainExperience(xpGained);
            UpdateCombatLog($"Player gains {xpGained} experience points.");

            SaveCharacter(player); // Save the player's updated state
        }

        private int CalculateExperiencePoints(Main.DifficultyLevel difficulty, int totalEnemyStrength)
        {
            int baseXP = difficulty switch
            {
                Main.DifficultyLevel.Easy => 10,
                Main.DifficultyLevel.Normal => 25,
                Main.DifficultyLevel.Hard => 50,
                Main.DifficultyLevel.BossSlaughter => 100,
                _ => 10,
            };

            return baseXP + (totalEnemyStrength / 2); // Example calculation
        }

        private void SaveCharacter(Character character)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, JsonConvert.SerializeObject(character));
        }

        private void UpdateCombatLog(string message)
        {
            combatLogTextBox.AppendText($"{message}{Environment.NewLine}");
        }

        private void UpdateDodgeCounterLabel()
        {
            dodgeCounterLabel.Text = $"Dodges Left: {dodgeCounter}";
        }

        private void CombatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!playerFled && player.Health > 0 && enemies.Any(e => e.Health > 0))
            {
                MessageBox.Show("You cannot close the combat form without fleeing.");
                e.Cancel = true;
            }
            else
            {
                combatFormOpen = false;
            }
        }
    }
}

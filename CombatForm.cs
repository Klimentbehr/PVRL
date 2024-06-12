using Main;
using Newtonsoft.Json;

namespace PVRL
{
    public partial class CombatForm : Form
    {
        private static bool combatFormOpen = false;
        private Character player;
        private Character enemy;
        private Main.DifficultyLevel difficulty;
        private Vault vault;
        private bool playerFled = false;
        public bool PlayerWon { get; private set; } = false;

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

            HealPlayerToFull(); // Heal the player to full health before starting combat

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

            GenerateEnemy();
            InitializeHealthBars();
            UpdateCombatLog($"Player {player.Name} vs Enemy {enemy.Name}");
        }

        private void GenerateEnemy()
        {
            Random random = new Random();
            int health = 0;
            int strength = 0;
            string enemyName = "Enemy";

            switch (difficulty)
            {
                case Main.DifficultyLevel.Easy:
                    health = random.Next(20, 41); // Enemy health between 20 and 40
                    strength = random.Next(5, 10); // Lower strength for easy enemies
                    if (random.Next(0, 100) < 5) enemyName = "Mini-Boss";
                    break;
                case Main.DifficultyLevel.Normal:
                    health = random.Next(40, 100); // Enemy health between 40 and 100
                    strength = random.Next(10, 20); // Medium strength for normal enemies
                    if (random.Next(0, 100) < 15) enemyName = "Mini-Boss";
                    break;
                case Main.DifficultyLevel.Hard:
                    health = random.Next(100, 200); // Enemy health between 100 and 200
                    strength = random.Next(20, 50); // Higher strength for hard enemies
                    if (random.Next(0, 100) < 25) enemyName = "Boss";
                    break;
                case Main.DifficultyLevel.BossSlaughter:
                    health = random.Next(250, 2000); // Enemy health between 250 and 2000
                    strength = random.Next(50, 500); // Extremely high strength for Boss Slaughter enemies
                    enemyName = "Boss";
                    break;
            }

            GunGeneration gunGenerator = new GunGeneration();
            GunGeneration.Gun enemyGun = gunGenerator.GenerateRandomGun(difficulty);

            enemy = new Character
            {
                Name = enemyName,
                Health = health,
                Strength = strength,
                Gun = enemyGun,
                Type = Character.CharacterType.EnemyMedium // Example type, can be adjusted
            };
        }

        private void InitializeHealthBars()
        {
            playerHealthBar.Maximum = player.MaxHealth;
            playerHealthBar.Value = player.Health;
            playerHealthLabel.Text = $"Player Health: {player.Health}/{player.MaxHealth}";

            enemyHealthBar.Maximum = enemy.Health;
            enemyHealthBar.Value = enemy.Health;
            enemyHealthLabel.Text = $"Enemy Health: {enemy.Health}";

            attackButton.Enabled = true;
            itemButton.Enabled = true;
            healButton.Enabled = true;
            fleeButton.Enabled = true;
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int hitChance = random.Next(1, 101);
            int playerDamage = CalculateDamage(player.Gun.Damage, hitChance, player.Strength);

            hitChance = random.Next(1, 101);
            int enemyDamage = CalculateDamage(enemy.Strength, hitChance);

            enemy.Health -= playerDamage;
            player.Health -= Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player)); // Subtracting armor defense

            if (enemy.Health < 0) enemy.Health = 0;
            if (player.Health < 0) player.Health = 0;

            UpdateHealthBars();
            UpdateCombatLog($"Player attacks enemy for {playerDamage} damage.");
            UpdateCombatLog($"Enemy attacks player for {enemyDamage} damage (reduced by armor to {Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player))}).");

            CheckCombatEnd();
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

        private void HealButton_Click(object sender, EventArgs e)
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
                player.Health += selectedHealingItem.HealAmount;

                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth; // Ensure health doesn't exceed max health
                }

                player.HealingItems.Remove(selectedHealingItem); // Remove used healing item
                UpdateHealthBars();
                UpdateCombatLog($"Player uses {selectedHealingItem.Name} and heals for {selectedHealingItem.HealAmount} health.");
                CheckCombatEnd();
            }
        }

        private void FleeButton_Click(object sender, EventArgs e)
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

        private void EnemyFreeAttack()
        {
            Random random = new Random();
            int hitChance = random.Next(1, 101);
            int enemyDamage = CalculateDamage(enemy.Strength, hitChance);

            player.Health -= Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player)); // Subtracting armor defense
            if (player.Health < 0) player.Health = 0;

            UpdateHealthBars();
            UpdateCombatLog($"Enemy attacks player for {enemyDamage} damage (reduced by armor to {Math.Max(0, enemyDamage - CalculateTotalArmorDefense(player))}) during flee attempt.");
            CheckCombatEnd();
        }

        private void UpdateHealthBars()
        {
            playerHealthBar.Value = player.Health;
            playerHealthLabel.Text = $"Player Health: {player.Health}/{player.MaxHealth}";

            enemyHealthBar.Value = enemy.Health;
            enemyHealthLabel.Text = $"Enemy Health: {enemy.Health}";
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
            else if (enemy.Health <= 0)
            {
                UpdateCombatLog("Enemy has been defeated!");
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
            combatFormOpen = false;
        }

        private void HandleLoot()
        {
            Random random = new Random();
            int gunDropChance = difficulty == Main.DifficultyLevel.Easy ? 5 : (difficulty == Main.DifficultyLevel.Normal ? 15 : (difficulty == Main.DifficultyLevel.Hard ? 50 : 100));

            if (random.Next(0, 100) < gunDropChance || difficulty == Main.DifficultyLevel.BossSlaughter) // Gun drop chance based on difficulty or guaranteed in Boss Slaughter
            {
                vault.AddGun(enemy.Gun);
                UpdateCombatLog("Enemy dropped a weapon!");
            }

            int moneyLooted = random.Next(difficulty == Main.DifficultyLevel.Easy ? 1 : (difficulty == Main.DifficultyLevel.Normal ? 2 : (difficulty == Main.DifficultyLevel.Hard ? 3 : 4)),
                                          difficulty == Main.DifficultyLevel.Easy ? 6 : (difficulty == Main.DifficultyLevel.Normal ? 11 : (difficulty == Main.DifficultyLevel.Hard ? 16 : 21))); // Adjusted credit payout based on difficulty
            player.Wallet += moneyLooted;
            UpdateCombatLog($"Player loots {moneyLooted} credits.");

            int xpGained = CalculateExperiencePoints(difficulty, enemy.Strength);
            player.GainExperience(xpGained);
            UpdateCombatLog($"Player gains {xpGained} experience points.");

            SaveCharacter(player); // Save the player's updated state
        }

        private int CalculateExperiencePoints(Main.DifficultyLevel difficulty, int enemyStrength)
        {
            int baseXP = difficulty switch
            {
                Main.DifficultyLevel.Easy => 10,
                Main.DifficultyLevel.Normal => 25,
                Main.DifficultyLevel.Hard => 50,
                Main.DifficultyLevel.BossSlaughter => 100,
                _ => 10,
            };

            return baseXP + (enemyStrength / 2); // Example calculation
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

        private void CombatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!playerFled && player.Health > 0 && enemy.Health > 0)
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

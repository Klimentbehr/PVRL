using System;
using System.Collections.Generic;

namespace PVRL.Functions
{
    public class Enemy : Character
    {
        public static List<Enemy> GenerateEnemies(DifficultyLevel difficulty, bool isBossFight = false)
        {
            List<Enemy> enemies = new List<Enemy>();
            Random random = new Random();

            if (isBossFight)
            {
                enemies.Add(GenerateBoss(difficulty));
            }
            else
            {
                int numEnemies = difficulty switch
                {
                    DifficultyLevel.Easy => random.Next(1, 4),
                    DifficultyLevel.Normal => random.Next(1, 4),
                    DifficultyLevel.Hard => random.Next(2, 4),
                    DifficultyLevel.BossSlaughter => 1,
                    _ => 1
                };

                for (int i = 0; i < numEnemies; i++)
                {
                    enemies.Add(GenerateRegularEnemy(difficulty, random));
                }
            }

            return enemies;
        }

        private static Enemy GenerateRegularEnemy(DifficultyLevel difficulty, Random random)
        {
            int health, strength;
            string enemyName = "Enemy";
            bool isBoss = false;

            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    health = random.Next(20, 41);
                    strength = random.Next(1, 5);
                    if (random.Next(0, 100) < 5)
                    {
                        enemyName = "Mini-Boss";
                        isBoss = true;
                    }
                    break;
                case DifficultyLevel.Normal:
                    health = random.Next(40, 100);
                    strength = random.Next(10, 20);
                    if (random.Next(0, 100) < 15)
                    {
                        enemyName = "Mini-Boss";
                        isBoss = true;
                    }
                    break;
                case DifficultyLevel.Hard:
                    health = random.Next(100, 200);
                    strength = random.Next(20, 50);
                    if (random.Next(0, 100) < 25)
                    {
                        enemyName = "Boss";
                        isBoss = true;
                    }
                    break;
                case DifficultyLevel.BossSlaughter:
                    health = random.Next(250, 2000);
                    strength = random.Next(50, 500);
                    enemyName = "Boss";
                    isBoss = true;
                    break;
                default:
                    health = 50;
                    strength = 10;
                    break;
            }

            // Adjust health and strength for bosses based on difficulty
            if (isBoss)
            {
                health = AdjustHealthForBoss(difficulty, health);
                strength = AdjustStrengthForBoss(difficulty, strength);
            }

            GunGeneration gunGenerator = new GunGeneration();
            GunGeneration.Gun enemyGun = gunGenerator.GenerateRandomGun(difficulty);

            return new Enemy
            {
                Name = enemyName,
                Health = health,
                MaxHealth = health,
                Strength = strength,
                Gun = enemyGun,
                Type = CharacterType.EnemyMedium // Example type, can be adjusted
            };
        }

        private static Enemy GenerateBoss(DifficultyLevel difficulty)
        {
            int health, strength;
            string bossName;

            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    health = 200;
                    strength = 30;
                    bossName = "Easy Boss";
                    break;
                case DifficultyLevel.Normal:
                    health = 400;
                    strength = 60;
                    bossName = "Normal Boss";
                    break;
                case DifficultyLevel.Hard:
                    health = 800;
                    strength = 120;
                    bossName = "Hard Boss";
                    break;
                case DifficultyLevel.BossSlaughter:
                    health = 2000;
                    strength = 300;
                    bossName = "Ultimate Boss";
                    break;
                default:
                    health = 200;
                    strength = 30;
                    bossName = "Boss";
                    break;
            }

            GunGeneration gunGenerator = new GunGeneration();
            GunGeneration.Gun bossGun = gunGenerator.GenerateRandomGun(difficulty);

            return new Enemy
            {
                Name = bossName,
                Health = health,
                MaxHealth = health,
                Strength = strength,
                Gun = bossGun,
                Type = CharacterType.Boss // Adjusted to new CharacterType.Boss
            };
        }

        private static int AdjustHealthForBoss(DifficultyLevel difficulty, int baseHealth)
        {
            return difficulty switch
            {
                DifficultyLevel.Easy => baseHealth * 2,
                DifficultyLevel.Normal => baseHealth * 2,
                DifficultyLevel.Hard => baseHealth * 3,
                DifficultyLevel.BossSlaughter => baseHealth * 2,
                _ => baseHealth
            };
        }

        private static int AdjustStrengthForBoss(DifficultyLevel difficulty, int baseStrength)
        {
            return difficulty switch
            {
                DifficultyLevel.Easy => baseStrength,
                DifficultyLevel.Normal => baseStrength * 3,
                DifficultyLevel.Hard => baseStrength * 4,
                DifficultyLevel.BossSlaughter => baseStrength * 2,
                _ => baseStrength
            };
        }
    }
}
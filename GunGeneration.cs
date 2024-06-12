using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Main
{
    public class GunGeneration
    {
        private static Random random = new Random();
        private static readonly string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GeneratedFiles");

        public enum GunOrigin
        {
            Civilian,
            Military
        }

        public enum GunType
        {
            Light,
            Medium,
            Heavy
        }

        public class Gun
        {
            public string ID { get; set; }
            public GunOrigin Origin { get; set; }
            public GunType Type { get; set; }
            public string UpperReceiver { get; set; }
            public string Barrel { get; set; }
            public string LowerReceiver { get; set; }
            public string BufferTube { get; set; }
            public string Stock { get; set; }
            public string Grip { get; set; }
            public string Trigger { get; set; }
            public int Damage { get; set; }
            public int Accuracy { get; set; }
            public int Range { get; set; }
            public int FireRate { get; set; }
            public float Weight { get; set; }
            public int Price { get; set; }
            public string Name { get; set; }

            public Gun(string id, GunOrigin origin, GunType type,
                string upperReceiver, string barrel, string lowerReceiver,
                string bufferTube, string stock, string grip, string trigger,
                int damage, int accuracy, int range, int fireRate, float weight, int price, string name = "Unnamed Gun")
            {
                ID = id;
                Origin = origin;
                Type = type;
                UpperReceiver = upperReceiver;
                Barrel = barrel;
                LowerReceiver = lowerReceiver;
                BufferTube = bufferTube;
                Stock = stock;
                Grip = grip;
                Trigger = trigger;
                Damage = damage;
                Accuracy = accuracy;
                Range = range;
                FireRate = fireRate;
                Weight = weight;
                Price = price;
                Name = name;
            }

            public override string ToString()
            {
                return $"Name: {Name}\n" +
                       $"ID: {ID}\n" +
                       $"Origin: {Origin}\n" +
                       $"Type: {Type}\n" +
                       $"Upper Receiver: {UpperReceiver}\n" +
                       $"Barrel: {Barrel}\n" +
                       $"Lower Receiver: {LowerReceiver}\n" +
                       $"Buffer Tube: {BufferTube}\n" +
                       $"Stock: {Stock}\n" +
                       $"Grip: {Grip}\n" +
                       $"Trigger: {Trigger}\n" +
                       $"Damage: {Damage}\n" +
                       $"Accuracy: {Accuracy}\n" +
                       $"Range: {Range}\n" +
                       $"Fire Rate: {FireRate}\n" +
                       $"Weight: {Weight}\n" +
                       $"Price: {Price}";
            }

            public void SwapPart(Gun otherGun, string partType)
            {
                switch (partType)
                {
                    case "UpperReceiver":
                        (UpperReceiver, otherGun.UpperReceiver) = (otherGun.UpperReceiver, UpperReceiver);
                        break;
                    case "Barrel":
                        (Barrel, otherGun.Barrel) = (otherGun.Barrel, Barrel);
                        break;
                    case "LowerReceiver":
                        (LowerReceiver, otherGun.LowerReceiver) = (otherGun.LowerReceiver, LowerReceiver);
                        break;
                    case "BufferTube":
                        (BufferTube, otherGun.BufferTube) = (otherGun.BufferTube, BufferTube);
                        break;
                    case "Stock":
                        (Stock, otherGun.Stock) = (otherGun.Stock, Stock);
                        break;
                    case "Grip":
                        (Grip, otherGun.Grip) = (otherGun.Grip, Grip);
                        break;
                    case "Trigger":
                        (Trigger, otherGun.Trigger) = (otherGun.Trigger, Trigger);
                        break;
                }
                // Recalculate the stats based on the new parts' qualities
                RecalculateStats();
            }

            private void RecalculateStats()
            {
                // Recalculate stats based on part qualities
                Damage = 10 + GunGeneration.DetermineStatBonus(UpperReceiver.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(Barrel.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(LowerReceiver.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(BufferTube.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(Stock.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(Grip.Split('.')[1])
                            + GunGeneration.DetermineStatBonus(Trigger.Split('.')[1]);

                if (Origin == GunOrigin.Military)
                {
                    Damage = (int)(Damage * 1.5); // Military guns deal 50% more damage
                }

                Accuracy = 50 + GunGeneration.DetermineStatBonus(UpperReceiver.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(Barrel.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(LowerReceiver.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(BufferTube.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(Stock.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(Grip.Split('.')[1])
                              + GunGeneration.DetermineStatBonus(Trigger.Split('.')[1]);

                // Apply caps based on gun type
                switch (Type)
                {
                    case GunType.Light:
                        Damage = Math.Min(Damage, 20);
                        Accuracy = Math.Min(Accuracy, 90);
                        break;
                    case GunType.Medium:
                        Damage = Math.Min(Damage, 50);
                        Accuracy = Math.Min(Accuracy, 70);
                        break;
                    case GunType.Heavy:
                        Damage = Math.Min(Damage, 100);
                        Accuracy = Math.Min(Accuracy, 50);
                        break;
                }
            }

            public void UpgradePart(string newPart, string partType)
            {
                switch (partType)
                {
                    case "UpperReceiver":
                        UpperReceiver = newPart;
                        break;
                    case "Barrel":
                        Barrel = newPart;
                        break;
                    case "LowerReceiver":
                        LowerReceiver = newPart;
                        break;
                    case "BufferTube":
                        BufferTube = newPart;
                        break;
                    case "Stock":
                        Stock = newPart;
                        break;
                    case "Grip":
                        Grip = newPart;
                        break;
                    case "Trigger":
                        Trigger = newPart;
                        break;
                }
                RecalculateStats();
            }
        }

        private static string GeneratePartID()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        private static string SelectQualityDescriptor()
        {
            List<(string descriptor, double probability)> qualityDescriptors = new List<(string, double)>
            {
                ("Poor", 0.50),
                ("Standard", 0.30),
                ("Superior", 0.15),
                ("First-rate", 0.05)
            };

            double roll = random.NextDouble();
            double cumulative = 0.0;

            foreach (var (descriptor, probability) in qualityDescriptors)
            {
                cumulative += probability;
                if (roll < cumulative)
                {
                    return descriptor;
                }
            }

            return "Standard"; // Default case
        }

        public static int DetermineStatBonus(string qualityDescriptor)
        {
            return qualityDescriptor switch
            {
                "Poor" => 0,
                "Standard" => 5,
                "Superior" => 10,
                "First-rate" => 20,
                _ => 0,
            };
        }

        public static int DeterminePartPrice(string qualityDescriptor)
        {
            return qualityDescriptor switch
            {
                "Poor" => 50,
                "Standard" => 100,
                "Superior" => 500,
                "First-rate" => 1000,
                _ => 100,
            };
        }

        public Gun GenerateRandomGun(DifficultyLevel difficulty)
        {
            GunOrigin origin = DetermineGunOrigin(difficulty);
            GunType type = (GunType)random.Next(3);
            string id = GeneratePartID();

            int standardPartCount = 0;
            int superiorPartCount = 0;
            int firstRatePartCount = 0;

            // Pre-generate quality descriptors based on difficulty
            string[] qualityDescriptors = new string[7];
            for (int i = 0; i < 7; i++)
            {
                switch (difficulty)
                {
                    case DifficultyLevel.Easy:
                        qualityDescriptors[i] = SelectEasyQualityDescriptor(ref standardPartCount);
                        break;
                    case DifficultyLevel.Normal:
                        qualityDescriptors[i] = SelectNormalQualityDescriptor(ref standardPartCount, ref superiorPartCount);
                        break;
                    case DifficultyLevel.Hard:
                        qualityDescriptors[i] = SelectHardQualityDescriptor(ref superiorPartCount);
                        break;
                    case DifficultyLevel.BossSlaughter:
                        qualityDescriptors[i] = SelectBossSlaughterQualityDescriptor(ref superiorPartCount, ref firstRatePartCount);
                        break;
                }
            }

            // Randomize the assignment of parts
            string[] parts = { "UpperReceiver", "Barrel", "LowerReceiver", "BufferTube", "Stock", "Grip", "Trigger" };
            parts = parts.OrderBy(x => random.Next()).ToArray();

            string upperReceiver = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "UpperReceiver")];
            string barrel = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "Barrel")];
            string lowerReceiver = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "LowerReceiver")];
            string bufferTube = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "BufferTube")];
            string stock = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "Stock")];
            string grip = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "Grip")];
            string trigger = GeneratePartID() + "." + qualityDescriptors[Array.IndexOf(parts, "Trigger")];

            // Calculate the price of the gun based on the parts
            int price = DeterminePartPrice(qualityDescriptors[0]) +
                        DeterminePartPrice(qualityDescriptors[1]) +
                        DeterminePartPrice(qualityDescriptors[2]) +
                        DeterminePartPrice(qualityDescriptors[3]) +
                        DeterminePartPrice(qualityDescriptors[4]) +
                        DeterminePartPrice(qualityDescriptors[5]) +
                        DeterminePartPrice(qualityDescriptors[6]);

            // Apply stat bonuses based on quality
            int baseDamage = 10;
            int damage = Math.Max(5, baseDamage + DetermineStatBonus(qualityDescriptors[0])); // Ensure damage doesn't fall below 5

            // Apply caps based on gun type
            damage = type switch
            {
                GunType.Light => Math.Min(damage, 20),
                GunType.Medium => Math.Min(damage, 50),
                GunType.Heavy => Math.Min(damage, 100),
                _ => damage
            };

            int accuracy = 50 + DetermineStatBonus(qualityDescriptors[1]);
            accuracy = type switch
            {
                GunType.Light => Math.Min(accuracy, 90),
                GunType.Medium => Math.Min(accuracy, 70),
                GunType.Heavy => Math.Min(accuracy, 50),
                _ => accuracy
            };

            int range = 100 + DetermineStatBonus(qualityDescriptors[2]);
            int fireRate = 10 + DetermineStatBonus(qualityDescriptors[3]);
            float weight = 5.0f + (float)random.NextDouble() * 5.0f; // Example base weight

            return new Gun(id, origin, type,
                upperReceiver,
                barrel,
                lowerReceiver,
                bufferTube,
                stock,
                grip,
                trigger,
                damage,
                accuracy,
                range,
                fireRate,
                weight,
                price);
        }

        public Gun GenerateStartingGun()
        {
            GunOrigin origin = GunOrigin.Civilian; // Starting guns are civilian
            GunType type = (GunType)random.Next(3);
            string id = GeneratePartID();

            string qualityDescriptor = "Poor"; // Ensure all parts are "Poor" quality

            string upperReceiver = GeneratePartID() + "." + qualityDescriptor;
            string barrel = GeneratePartID() + "." + qualityDescriptor;
            string lowerReceiver = GeneratePartID() + "." + qualityDescriptor;
            string bufferTube = GeneratePartID() + "." + qualityDescriptor;
            string stock = GeneratePartID() + "." + qualityDescriptor;
            string grip = GeneratePartID() + "." + qualityDescriptor;
            string trigger = GeneratePartID() + "." + qualityDescriptor;

            // Calculate the price of the gun based on the parts
            int price = DeterminePartPrice(qualityDescriptor) * 7; // All parts are "Poor" quality

            // Apply stat bonuses based on quality
            int baseDamage = 5;
            int damage = Math.Max(1, baseDamage + DetermineStatBonus(qualityDescriptor)); // Ensure damage doesn't fall below 1

            // Apply caps based on gun type
            damage = type switch
            {
                GunType.Light => Math.Min(damage, 10),
                GunType.Medium => Math.Min(damage, 20),
                GunType.Heavy => Math.Min(damage, 30),
                _ => damage
            };

            int accuracy = 30 + DetermineStatBonus(qualityDescriptor);
            accuracy = type switch
            {
                GunType.Light => Math.Min(accuracy, 60),
                GunType.Medium => Math.Min(accuracy, 50),
                GunType.Heavy => Math.Min(accuracy, 40),
                _ => accuracy
            };

            int range = 50 + DetermineStatBonus(qualityDescriptor);
            int fireRate = 5 + DetermineStatBonus(qualityDescriptor);
            float weight = 7.0f + (float)random.NextDouble() * 3.0f; // Example base weight

            return new Gun(id, origin, type,
                upperReceiver,
                barrel,
                lowerReceiver,
                bufferTube,
                stock,
                grip,
                trigger,
                damage,
                accuracy,
                range,
                fireRate,
                weight,
                price);
        }

        private GunOrigin DetermineGunOrigin(DifficultyLevel difficulty)
        {
            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    return GunOrigin.Civilian; // No military guns in easy mode
                case DifficultyLevel.Normal:
                    return random.Next(100) < 10 ? GunOrigin.Military : GunOrigin.Civilian; // 10% chance for military in normal mode
                case DifficultyLevel.Hard:
                    return random.Next(100) < 50 ? GunOrigin.Military : GunOrigin.Civilian; // 50% chance for military in hard mode
                case DifficultyLevel.BossSlaughter:
                    return GunOrigin.Military; // 100% chance for military in BossSlaughter mode
                default:
                    return GunOrigin.Civilian;
            }
        }

        private string SelectEasyQualityDescriptor(ref int standardPartCount)
        {
            if (standardPartCount < 2)
            {
                standardPartCount++;
                return "Standard";
            }
            return "Poor";
        }

        private string SelectNormalQualityDescriptor(ref int standardPartCount, ref int superiorPartCount)
        {
            if (standardPartCount < 4)
            {
                standardPartCount++;
                return random.NextDouble() > 0.5 ? "Superior" : "Standard";
            }
            else if (superiorPartCount < 2)
            {
                superiorPartCount++;
                return "Superior";
            }
            return "Standard";
        }

        private string SelectHardQualityDescriptor(ref int superiorPartCount)
        {
            if (superiorPartCount < 4)
            {
                superiorPartCount++;
                return "Superior";
            }
            return random.NextDouble() > 0.5 ? "First-rate" : "Superior";
        }

        private string SelectBossSlaughterQualityDescriptor(ref int superiorPartCount, ref int firstRatePartCount)
        {
            if (superiorPartCount < 6)
            {
                superiorPartCount++;
                return "Superior";
            }
            else if (firstRatePartCount < 1)
            {
                firstRatePartCount++;
                return "First-rate";
            }
            return "Superior";
        }

        public async Task GenerateAndSaveRandomGuns(int numberOfGuns, DifficultyLevel difficulty)
        {
            List<Gun> guns = new List<Gun>();
            await Task.Run(() =>
            {
                Parallel.For(0, numberOfGuns, i =>
                {
                    guns.Add(GenerateRandomGun(difficulty));
                });
            });

            await SaveGunsToFile(guns, "Guns.txt");
        }

        private async Task SaveGunsToFile(List<Gun> guns, string fileName)
        {
            string filePath = Path.Combine(directoryPath, fileName);
            Directory.CreateDirectory(directoryPath); // Ensure the directory exists

            using StreamWriter file = new StreamWriter(filePath);
            foreach (var gun in guns)
            {
                await file.WriteLineAsync(JsonConvert.SerializeObject(gun));
                await file.WriteLineAsync(); // Add an empty line for readability between gun entries
            }

            Console.WriteLine($"{guns.Count} guns have been generated and saved to {filePath}");
        }
    }

    public enum DifficultyLevel
    {
        Easy,
        Normal,
        Hard,
        BossSlaughter
    }
}

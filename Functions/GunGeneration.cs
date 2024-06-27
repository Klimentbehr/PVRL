using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PVRL.Functions
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

        public class GunPart
        {
            public string ID { get; set; }
            public string Quality { get; set; }
            public GunOrigin Origin { get; set; }

            public GunPart(string id, string quality, GunOrigin origin)
            {
                ID = id;
                Quality = quality;
                Origin = origin;
            }

            public override string ToString()
            {
                return $"{ID}.{Quality}.{Origin}";
            }

            public static GunPart FromString(string partString)
            {
                var parts = partString.Split('.');
                var id = parts[0];
                var quality = parts[1];
                var origin = (GunOrigin)Enum.Parse(typeof(GunOrigin), parts[2]);
                return new GunPart(id, quality, origin);
            }
        }

        public class Gun
        {
            public string ID { get; set; }
            public GunOrigin Origin { get; set; }
            public GunType Type { get; set; }
            public GunPart UpperReceiver { get; set; }
            public GunPart Barrel { get; set; }
            public GunPart LowerReceiver { get; set; }
            public GunPart BufferTube { get; set; }
            public GunPart Stock { get; set; }
            public GunPart Grip { get; set; }
            public GunPart Trigger { get; set; }
            public int Damage { get; set; }
            public int Accuracy { get; set; }
            public int Range { get; set; }
            public int FireRate { get; set; }
            public float Weight { get; set; }
            public int Price { get; set; }
            public string Name { get; set; }
            public float DamageMultiplier { get; set; }  // Add this property

            public Gun(string id, GunOrigin origin, GunType type, GunPart upperReceiver, GunPart barrel, GunPart lowerReceiver, GunPart bufferTube, GunPart stock, GunPart grip, GunPart trigger, int damage, int accuracy, int range, int fireRate, float weight, int price, string name = "Unnamed Gun", bool skipRecalculation = false)
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
                DamageMultiplier = 1.0f;  // Initialize the property
                if (!skipRecalculation)
                {
                    RecalculateStats();
                }
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
                       $"Price: {Price}\n" +
                       $"Damage Multiplier: {DamageMultiplier}";  // Include the property in the string representation
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
                Damage = 10 + DetermineStatBonus(UpperReceiver.Quality, UpperReceiver.Origin)
                            + DetermineStatBonus(Barrel.Quality, Barrel.Origin)
                            + DetermineStatBonus(LowerReceiver.Quality, LowerReceiver.Origin)
                            + DetermineStatBonus(BufferTube.Quality, BufferTube.Origin)
                            + DetermineStatBonus(Stock.Quality, Stock.Origin)
                            + DetermineStatBonus(Grip.Quality, Grip.Origin)
                            + DetermineStatBonus(Trigger.Quality, Trigger.Origin);

                if (Origin == GunOrigin.Military)
                {
                    Damage = (int)(Damage * 1.5); // Military guns deal 50% more damage
                }

                Accuracy = 50 + DetermineStatBonus(UpperReceiver.Quality, UpperReceiver.Origin)
                              + DetermineStatBonus(Barrel.Quality, Barrel.Origin)
                              + DetermineStatBonus(LowerReceiver.Quality, LowerReceiver.Origin)
                              + DetermineStatBonus(BufferTube.Quality, BufferTube.Origin)
                              + DetermineStatBonus(Stock.Quality, Stock.Origin)
                              + DetermineStatBonus(Grip.Quality, Grip.Origin)
                              + DetermineStatBonus(Trigger.Quality, Trigger.Origin);

                // Apply caps based on gun type
                switch (Type)
                {
                    case GunType.Light:
                        Damage = Math.Min(Damage, 45);
                        Accuracy = Math.Min(Accuracy, 90);
                        FireRate = Math.Min(FireRate, 50);
                        break;
                    case GunType.Medium:
                        Damage = Math.Min(Damage, 75);
                        Accuracy = Math.Min(Accuracy, 70);
                        FireRate = Math.Min(FireRate, 30);
                        break;
                    case GunType.Heavy:
                        Damage = Math.Min(Damage, 100);
                        Accuracy = Math.Min(Accuracy, 50);
                        FireRate = Math.Min(FireRate, 20);
                        break;
                }
            }

            public void UpgradePart(GunPart newPart, string partType)
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

        public static int DetermineStatBonus(string qualityDescriptor, GunOrigin origin)
        {
            int baseBonus = qualityDescriptor switch
            {
                "Poor" => 0,
                "Standard" => 5,
                "Superior" => 10, // Adjusted bonuses
                "First-rate" => 15, // Adjusted bonuses
                _ => 0,
            };
            return origin == GunOrigin.Military ? (int)(baseBonus * 1.5) : baseBonus; // Military parts have 50% more bonus
        }

        public static int DeterminePartPrice(string qualityDescriptor)
        {
            return qualityDescriptor switch
            {
                "Poor" => 100,
                "Standard" => 150,
                "Superior" => 500,
                "First-rate" => 2000,
                _ => 100,
            };
        }

        public Gun GenerateRaceSpecificGun(GunType type, int maxDamage)
        {
            GunOrigin origin = GunOrigin.Civilian; // Assume civilian origin for starting guns
            string id = GeneratePartID();
            string qualityDescriptor = "Standard"; // Use standard quality for race-specific guns

            GunPart upperReceiver = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart barrel = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart lowerReceiver = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart bufferTube = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart stock = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart grip = new GunPart(GeneratePartID(), qualityDescriptor, origin);
            GunPart trigger = new GunPart(GeneratePartID(), qualityDescriptor, origin);

            // Calculate the price of the gun based on the parts
            int price = DeterminePartPrice(qualityDescriptor) * 7;

            // Apply stat bonuses based on quality
            int damage = Math.Min(maxDamage, maxDamage + DetermineStatBonus(qualityDescriptor, origin));

            int accuracy = 50 + DetermineStatBonus(qualityDescriptor, origin);
            int range = 100 + DetermineStatBonus(qualityDescriptor, origin);
            int fireRate = 10 + DetermineStatBonus(qualityDescriptor, origin);
            float weight = 5.0f + (float)random.NextDouble() * 5.0f;

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

        public Gun GenerateStartingGun(string race)
        {
            GunOrigin origin = GunOrigin.Civilian; // Starting guns are civilian
            GunType type;
            int damage;
            int fireRate;
            int accuracy = 50; // Default accuracy for light and medium guns

            GunPart upperReceiver = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart barrel = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart lowerReceiver = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart bufferTube = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart stock = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart grip = new GunPart(GeneratePartID(), "Poor", origin);
            GunPart trigger = new GunPart(GeneratePartID(), "Poor", origin);

            switch (race)
            {
                case "Human":
                    type = GunType.Medium;
                    damage = 10;
                    fireRate = 10;
                    accuracy = 35;
                    break;
                case "Drone":
                    type = GunType.Heavy;
                    damage = 15;
                    fireRate = 10;
                    accuracy = 20; // Heavy guns start with 10 accuracy
                    break;
                case "Synth":
                    type = GunType.Light;
                    damage = 5;
                    fireRate = 15 + random.Next(6); // Randomize fire rate between 15 and 20
                    accuracy = 45;
                    break;
                default:
                    throw new ArgumentException("Invalid race specified.");
            }

            string id = GeneratePartID();

            // Calculate the price of the gun based on the parts
            int price = DeterminePartPrice("Poor") * 7; // All parts are "Poor" quality

            int range = 100 + DetermineStatBonus("Poor", origin);
            float weight = 5.0f + (float)random.NextDouble() * 5.0f;

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
                price,
                "Starting Gun", // Name of the gun
                true // Skip recalculating stats
            );
        }

        private string SelectEasyQualityDescriptor(ref int standardPartCount)
        {
            if (standardPartCount < 1) // Ensure one standard part for the boss
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

            GunPart upperReceiver = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "UpperReceiver")], origin);
            GunPart barrel = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "Barrel")], origin);
            GunPart lowerReceiver = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "LowerReceiver")], origin);
            GunPart bufferTube = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "BufferTube")], origin);
            GunPart stock = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "Stock")], origin);
            GunPart grip = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "Grip")], origin);
            GunPart trigger = new GunPart(GeneratePartID(), qualityDescriptors[Array.IndexOf(parts, "Trigger")], origin);

            // Calculate the price of the gun based on the parts
            int price = DeterminePartPrice(qualityDescriptors[0]) +
                        DeterminePartPrice(qualityDescriptors[1]) +
                        DeterminePartPrice(qualityDescriptors[2]) +
                        DeterminePartPrice(qualityDescriptors[3]) +
                        DeterminePartPrice(qualityDescriptors[4]) +
                        DeterminePartPrice(qualityDescriptors[5]) +
                        DeterminePartPrice(qualityDescriptors[6]);

            // Apply stat bonuses based on quality
            int baseDamage = type switch
            {
                GunType.Light => 5,
                GunType.Medium => 10,
                GunType.Heavy => 15,
                _ => 10
            };

            int damage = baseDamage + DetermineStatBonus(qualityDescriptors[0], origin);

            // Apply caps based on gun type
            damage = type switch
            {
                GunType.Light => Math.Min(damage, 45),
                GunType.Medium => Math.Min(damage, 75),
                GunType.Heavy => Math.Min(damage, 100),
                _ => damage
            };

            int baseFireRate = type switch
            {
                GunType.Light => 15,
                GunType.Medium => 10,
                GunType.Heavy => 10,
                _ => 10
            };

            int accuracy = type == GunType.Heavy ? 10 : 50;
            accuracy += DetermineStatBonus(qualityDescriptors[1], origin);
            accuracy = type switch
            {
                GunType.Light => Math.Min(accuracy, 90),
                GunType.Medium => Math.Min(accuracy, 70),
                GunType.Heavy => Math.Min(accuracy, 50),
                _ => accuracy
            };

            int range = 100 + DetermineStatBonus(qualityDescriptors[2], origin);
            int fireRate = baseFireRate + DetermineStatBonus(qualityDescriptors[3], origin);
            fireRate = type switch
            {
                GunType.Light => Math.Min(fireRate, 50),
                GunType.Medium => Math.Min(fireRate, 30),
                GunType.Heavy => Math.Min(fireRate, 20),
                _ => fireRate
            };

            float weight = 5.0f + (float)random.NextDouble() * 5.0f;

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
            return difficulty switch
            {
                DifficultyLevel.Easy => GunOrigin.Civilian, // No military guns in easy mode
                DifficultyLevel.Normal => random.Next(100) < 10 ? GunOrigin.Military : GunOrigin.Civilian, // 10% chance for military in normal mode
                DifficultyLevel.Hard => random.Next(100) < 50 ? GunOrigin.Military : GunOrigin.Civilian, // 50% chance for military in hard mode
                DifficultyLevel.BossSlaughter => GunOrigin.Military, // 100% chance for military in BossSlaughter mode
                _ => GunOrigin.Civilian
            };
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

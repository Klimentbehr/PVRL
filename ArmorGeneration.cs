﻿using System;
using System.Collections.Generic;

namespace Main
{
    public class ArmorGeneration
    {
        private static Random random = new Random();

        public enum ArmorType
        {
            Helmet,
            Vest
        }

        public class Armor
        {
            public string ID { get; set; }
            public ArmorType Type { get; set; }
            public string Material { get; set; }
            public int Defense { get; set; }
            public float Weight { get; set; }
            public int Price { get; set; }
            public string Name { get; set; }

            public Armor(string id, ArmorType type, string material, int defense, float weight, int price, string name = "Unnamed Armor")
            {
                ID = id;
                Type = type;
                Material = material;
                Defense = defense;
                Weight = weight;
                Price = price;
                Name = name;
            }

            public override string ToString()
            {
                return $"Name: {Name}\n" +
                       $"ID: {ID}\n" +
                       $"Type: {Type}\n" +
                       $"Material: {Material}\n" +
                       $"Defense: {Defense}\n" +
                       $"Weight: {Weight}\n" +
                       $"Price: {Price}";
            }
        }

        private static string GeneratePartID()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        public static List<Armor> GenerateRandomArmors(int numberOfArmors)
        {
            List<Armor> armors = new List<Armor>();
            for (int i = 0; i < numberOfArmors; i++)
            {
                ArmorType type = (ArmorType)random.Next(2);
                string id = GeneratePartID();
                string material = SelectRandomMaterial();
                int defense = random.Next(10, 51);
                float weight = (float)(random.NextDouble() * 10.0);
                int price = defense * 100;

                armors.Add(new Armor(id, type, material, defense, weight, price));
            }
            return armors;
        }

        private static string SelectRandomMaterial()
        {
            string[] materials = { "Kevlar", "Steel", "Titanium", "Carbon Fiber" };
            return materials[random.Next(materials.Length)];
        }
    }
}

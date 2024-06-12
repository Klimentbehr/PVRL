using System;
using System.Collections.Generic;

public static class HealingItemGenerator
{
    private static Random random = new Random();

    public static List<HealingItem> GenerateRandomHealingItems(int numberOfItems)
    {
        List<HealingItem> healingItems = new List<HealingItem>();
        for (int i = 0; i < numberOfItems; i++)
        {
            healingItems.Add(GenerateRandomHealingItem());
        }
        return healingItems;
    }

    public static HealingItem GenerateRandomHealingItem()
    {
        string qualityDescriptor = SelectQualityDescriptor();
        return GenerateHealingItem(qualityDescriptor);
    }

    public static HealingItem GenerateHealingItem(string qualityDescriptor)
    {
        string id = Guid.NewGuid().ToString().Substring(0, 8);
        string name = $"{qualityDescriptor} Healing Potion";
        int healAmount = DetermineHealAmount(qualityDescriptor);
        int price = DetermineItemPrice(qualityDescriptor);

        return new HealingItem(id, name, qualityDescriptor, healAmount, price);
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

    private static int DetermineHealAmount(string qualityDescriptor)
    {
        return qualityDescriptor switch
        {
            "Poor" => 10,
            "Standard" => 20,
            "Superior" => 50,
            "First-rate" => 100,
            _ => 20,
        };
    }

    private static int DetermineItemPrice(string qualityDescriptor)
    {
        return qualityDescriptor switch
        {
            "Poor" => 10,
            "Standard" => 20,
            "Superior" => 50,
            "First-rate" => 100,
            _ => 20,
        };
    }
}

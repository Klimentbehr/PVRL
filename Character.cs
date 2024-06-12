using System.Collections.Generic;
using Main;

public class Character
{
    public string Name { get; set; }
    public string Race { get; set; }
    public int Age { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; } // Add MaxHealth property
    public int Defense { get; set; }
    public CharacterType Type { get; set; }
    public GunGeneration.Gun Gun { get; set; }
    public List<GunGeneration.Gun> Inventory { get; set; } // Inventory for storing guns
    public List<HealingItem> HealingItems { get; set; } // Inventory for storing healing items
    public List<ArmorGeneration.Armor> Armors { get; set; } // Inventory for storing armors
    public int Wallet { get; set; }
    public int ExperiencePoints { get; set; }
    public int SkillPoints { get; set; }
    public int Level { get; set; }

    public enum CharacterType
    {
        Player,
        EnemyLight,
        EnemyMedium,
        EnemyHeavy
    }

    public Character()
    {
        MaxHealth = 100;
        Health = MaxHealth;
        Defense = 10;
        Wallet = 0;
        ExperiencePoints = 0;
        SkillPoints = 0;
        Level = 1;
        Inventory = new List<GunGeneration.Gun>(); // Initialize the Inventory list
        HealingItems = new List<HealingItem>(); // Initialize the HealingItems list
        Armors = new List<ArmorGeneration.Armor>(); // Initialize the Armors list
    }

    public void GainExperience(int points)
    {
        ExperiencePoints += points;
        while (ExperiencePoints >= ExperienceNeededForNextLevel())
        {
            ExperiencePoints -= ExperienceNeededForNextLevel();
            Level++;
            SkillPoints++;
            IncreaseHealth(); // Increase health with each level up
        }
    }

    private int ExperienceNeededForNextLevel()
    {
        return Level * 100;
    }

    private void IncreaseHealth()
    {
        MaxHealth += 10; // Increase max health by 10
        Health = MaxHealth; // Restore health to max health
    }

    public void UseHealingItem(HealingItem item)
    {
        if (HealingItems.Contains(item))
        {
            Health += item.HealAmount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth; // Ensure health doesn't exceed max health
            }
            HealingItems.Remove(item); // Remove the used healing item from the inventory
        }
    }

    public void AddHealingItem(HealingItem item)
    {
        HealingItems.Add(item);
    }

    public void EquipArmor(ArmorGeneration.Armor armor)
    {
        Armors.Add(armor);
        Defense += armor.Defense;
    }

    public void UnequipArmor(ArmorGeneration.Armor armor)
    {
        if (Armors.Contains(armor))
        {
            Armors.Remove(armor);
            Defense -= armor.Defense;
        }
    }
}

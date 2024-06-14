using System.Collections.Generic;
using PVRL.Functions;

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
    public int MaxHealth { get; set; }
    public int Defense { get; set; }
    public CharacterType Type { get; set; }
    public GunGeneration.Gun Gun { get; set; }
    public List<GunGeneration.Gun> Inventory { get; set; }
    public List<HealingItem> HealingItems { get; set; }
    public List<ArmorGeneration.Armor> Armors { get; set; }
    public int Wallet { get; set; }
    public int ExperiencePoints { get; set; }
    public int SkillPoints { get; set; }
    public int Level { get; set; }

    public enum CharacterType
    {
        Player,
        EnemyLight,
        EnemyMedium,
        EnemyHeavy,
        Boss
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
        Inventory = new List<GunGeneration.Gun>();
        HealingItems = new List<HealingItem>();
        Armors = new List<ArmorGeneration.Armor>();
    }

    public void GainExperience(int points)
    {
        ExperiencePoints += points;
        while (ExperiencePoints >= ExperienceNeededForNextLevel())
        {
            ExperiencePoints -= ExperienceNeededForNextLevel();
            Level++;
            SkillPoints++;
            IncreaseHealth();
        }
    }

    private int ExperienceNeededForNextLevel()
    {
        return Level * 100;
    }

    private void IncreaseHealth()
    {
        MaxHealth += 10;
        Health = MaxHealth;
    }

    public void UseHealingItem(HealingItem item)
    {
        if (HealingItems.Contains(item))
        {
            Health += item.HealAmount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
            HealingItems.Remove(item);
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
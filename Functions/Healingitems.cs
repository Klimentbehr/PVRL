using System;

public class HealingItem
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Quality { get; set; }
    public int HealAmount { get; set; }
    public int Price { get; set; }

    public HealingItem(string id, string name, string quality, int healAmount, int price)
    {
        ID = id;
        Name = name;
        Quality = quality;
        HealAmount = healAmount;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Quality: {Quality}\n" +
               $"Heal Amount: {HealAmount}\n" +
               $"Price: {Price}";
    }
}

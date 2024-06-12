using System;

namespace Main
{
    public class RepairKit
    {
        public string ID { get; set; }
        public string Quality { get; set; }
        public int RepairAmount { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public RepairKit(string id, string quality, int repairAmount, int price, string name = "Unnamed Repair Kit")
        {
            ID = id;
            Quality = quality;
            RepairAmount = repairAmount;
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"ID: {ID}\n" +
                   $"Quality: {Quality}\n" +
                   $"Repair Amount: {RepairAmount}\n" +
                   $"Price: {Price}";
        }
    }
}

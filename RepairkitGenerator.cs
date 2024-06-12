using System;

namespace Main
{
    public static class RepairKitGenerator
    {
        private static Random random = new Random();

        public static RepairKit GenerateRepairKit(string quality)
        {
            int repairAmount = quality switch
            {
                "Poor" => random.Next(1000, 5000),
                "Standard" => random.Next(5000, 15000),
                "Superior" => random.Next(15000, 50000),
                "First-rate" => random.Next(50000, 100000),
                _ => random.Next(1000, 5000),
            };

            int price = repairAmount / 10;

            return new RepairKit(Guid.NewGuid().ToString().Substring(0, 8), quality, repairAmount, price, $"{quality} Repair Kit");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVRL
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public string Type { get; set; } // e.g., "Gun", "Armor"
        public int Damage { get; set; }
        public int Defense { get; set; }
        // Add more properties as needed
    }

}

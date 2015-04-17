using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    class ItemManager
    {
        public List<Item> Items { get; set; }
        public ItemManager()
        {
            Items = new List<Item>();
        }
        public bool AddItem(Item item)
        {
            // Look for item with the same ID
            Item exists = Items.Find(a => a.ID == item.ID);
            if (exists != null & item.ID != 0) // If item has ID 0, it's a temporary item
            {
                // ID already in use, return false
                return false;
            }
            // ID not in use, add account to list and return true
            Items.Add(item);
            return true;
        }
    }
}

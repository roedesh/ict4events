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
        private List<Item> AvaillableItems;
        public List<Item> RentedItems { get; set; }
        public ItemManager()
        {
            Items = new List<Item>();
            AvaillableItems = new List<Item>();
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

        public List<Item> GetAvaillableItems()
        {
            AvaillableItems.Clear();
            foreach (Item item in Items)
            {
                if (item.Stock > 0 && item.IsReserved == false)
                {
                    AvaillableItems.Add(item);
                }
            }
            return AvaillableItems;
        }

        public bool AddRentedItem(Item item)
        {
            // Look for item with the same ID
            Item exists = RentedItems.Find(a => a.ID == item.ID);
            if (exists != null & item.ID != 0) // If item has ID 0, it's a temporary item
            {
                // ID already in use, return false
                return false;
            }
            // ID not in use, add account to list and return true
            RentedItems.Add(item);
            return true;
        }
    }
}

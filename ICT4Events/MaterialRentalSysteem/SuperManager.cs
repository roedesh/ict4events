using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace MaterialRentalSysteem
{
    class SuperManager
    {
        AccountManager accountManager;
        DataManager dataManager;
        ItemManager itemManager;
        public SuperManager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
            itemManager = new ItemManager();
        }
        public void AddItem(List<string> info)
        {
            dataManager.SetItem(info);
        }
        public List<Item> GetAllItems()
        {

            List<Dictionary<string, string>> list = dataManager.GetAllItems();
            Console.WriteLine(list);
            Item item;
            foreach (Dictionary<string, string> d in list)
            {
                item = new Item(Convert.ToInt32(d["ITEMID"]),
                                d["NAME"], d["TYPEITEM"],Convert.ToInt32(d["STOCK"]),
                                Convert.ToDecimal(d["PRICE"]));
                itemManager.AddItem(item);
                
            }
            return itemManager.Items;
        }
    }
}

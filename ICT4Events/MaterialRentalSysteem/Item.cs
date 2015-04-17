using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get ;set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Item(int id, string name, string type, int stock,decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Stock = stock;
            this.Price = price;
        }
        public override string ToString()
        {
            return Name + ", " + Type + "  Stock: " + Stock.ToString() + ",Price: " + Price.ToString();
        }
    }
}

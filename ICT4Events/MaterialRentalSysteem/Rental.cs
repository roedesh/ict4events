using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialRentalSysteem
{
    /// <summary>
    /// A rental is an item that is connected to a person.
    /// In the rental object is all information needed in the system saved.
    /// </summary>
    class Rental
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ItemType {get; set;}
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Amount { get; set; }
        public int ItemID { get; set; }
        public Rental(int id,string fullName,string itemType,string name,DateTime startDate,DateTime endDate,int amount,int itemID)
        {
            this.ID = id;
            this.FullName = fullName;
            this.ItemType = itemType;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Amount = amount;
            this.ItemID = itemID;
        }
        public override string ToString()
        {
            return FullName + " " + ItemType + " " + Name + " " + Amount.ToString() + " , Inleverdatum:" +EndDate.ToShortDateString();
        }
    }
}

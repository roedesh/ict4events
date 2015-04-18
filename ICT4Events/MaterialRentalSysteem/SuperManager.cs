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
            RefreshItems();
            return itemManager.Items;
        }
        public List<Item> Update()
        {
            return itemManager.Items;
        }
        public List<Item> GetAvaillableItems()
        {
            RefreshItems();
            return itemManager.GetAvaillableItems();
        }
        public void RefreshItems()
        {
            itemManager.Items.Clear();
            List<Dictionary<string, string>> list = dataManager.GetAllItems();
            Console.WriteLine(list);
            Item item;
            foreach (Dictionary<string, string> d in list)
            {
                item = new Item(Convert.ToInt32(d["ITEMID"]),
                                d["NAME"], d["TYPEITEM"], Convert.ToInt32(d["STOCK"]),
                                Convert.ToDecimal(d["PRICE"]));
                itemManager.AddItem(item);

            }
        }
        public List<string> GetAllRentedItems()
        {
            List<Dictionary<string, string>> list = dataManager.GetAllRentedItems();
            Console.WriteLine(list);
            List<string> rentedItems = new List<string>();
            foreach (Dictionary<string, string> d in list)
            {
                string info = "";
                string startDate = d["STARTDATE"];
                string endDate = d["ENDDATE"];
                startDate = startDate.Substring(0, 10);
                endDate = endDate.Substring(0, 10);
                info += d["ITEMRENTALID"] + ": " + d["FULLNAME"] + ": " + d["TYPEITEM"] + ", " + d["NAME"] + "Period: " + startDate + " - " + endDate;
                rentedItems.Add(info);
            }
            return rentedItems;
        }
        public void RemoveItem(Item item)
        {
            dataManager.DeleteItem(item.ID.ToString());
        }
        public void ChangeItem(List<string> newInfo,string id)
        {
            dataManager.UpdateItem(newInfo,id);
        }
        public void DeleteItem(Item item)
        {
            string id = item.ID.ToString();
            dataManager.DeleteItem(id);
        }
        public List<Guest> SearchPersonRFID(string RFID)
        {
            List<Guest> persons = new List<Guest>();
            Guest account;
            //GetUsername
            List<Dictionary<string, string>> list = dataManager.GetGuestAccountWithRFID(RFID);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                account = new Guest(Convert.ToInt32(d["ACCOUNTID"]),
                                    Convert.ToInt32(d["EVENTID"]),
                                    d["USERNAME"], d["PASSWORD"],
                                    d["FULLNAME"], d["ADRESS"],
                                    d["CITY"], d["POSTALCODE"],
                                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                                    d["EMAIL"], d["PHONENUMBER"], d["RFID"],
                                    d["ISPRESENT"], Convert.ToInt32(d["GUESTID"]));
                persons.Add(account);
            }
            return persons;
        }
        public void RentItem(Item item, Guest guest,string EndDate, string amount)
        {
            //gather initial needed data in correct form
            List<string> rentalInfo = new List<string>();
            List<string> itemRentalInfo = new List<string>();
            List<string> itemInfo = new List<string>();
            DateTime now = DateTime.Now;
            string guestID = guest.GuestID.ToString();
            string startDate = now.ToShortDateString();
            string endDate = EndDate;
            string totalAmount = amount;
            string RFIDguest = guest.RFID;
            string itemID = item.ID.ToString();

            //Give the guest a rental
            rentalInfo.Add(guestID);
            rentalInfo.Add(startDate);
            rentalInfo.Add(endDate);
            rentalInfo.Add(totalAmount);
            string rentalID = dataManager.SetRental(rentalInfo).ToString();
            

            //connect the rental with the item
            itemRentalInfo.Clear();
            itemRentalInfo.Add(itemID);
            itemRentalInfo.Add(rentalID);
            dataManager.SetItemRental(itemRentalInfo);

            //Remove 1 from the stock
            int stock = item.Stock;
            stock--;
            itemInfo.Add(item.Name);
            itemInfo.Add(item.Type);
            itemInfo.Add(stock.ToString());
            itemInfo.Add(item.Price.ToString());
            dataManager.UpdateItem(itemInfo, itemID);
        }
        public void TakeRental(string ID)
        {
             dataManager.DeleteItemRental(ID);
        }
        public List<Guest> GetAllGuests()
        {
            List<Guest> presentPersons = new List<Guest>();
            Guest account;
            List<Dictionary<string, string>> list = dataManager.GetAllPresentGuests();
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                account = new Guest(Convert.ToInt32(d["ACCOUNTID"]),
                                    Convert.ToInt32(d["EVENTID"]),
                                    d["USERNAME"], d["PASSWORD"],
                                    d["FULLNAME"], d["ADRESS"],
                                    d["CITY"], d["POSTALCODE"],
                                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                                    d["EMAIL"], d["PHONENUMBER"], d["RFID"],
                                    d["ISPRESENT"], Convert.ToInt32(d["GUESTID"]));
                presentPersons.Add(account);

            }
            return presentPersons;
        }
        public List<Guest> SearchPersonName(string name)
        {
            List<Guest> persons = new List<Guest>();
            Guest account;
            List<Dictionary<string, string>> list = dataManager.GetGuestAccountWithName(name);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                account = new Guest(Convert.ToInt32(d["ACCOUNTID"]),
                                    Convert.ToInt32(d["EVENTID"]),
                                    d["USERNAME"], d["PASSWORD"],
                                    d["FULLNAME"], d["ADRESS"],
                                    d["CITY"], d["POSTALCODE"],
                                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                                    d["EMAIL"], d["PHONENUMBER"], d["RFID"],
                                    d["ISPRESENT"], Convert.ToInt32(d["GUESTID"]));
                persons.Add(account);

            }
            return persons;
        }
    }
}

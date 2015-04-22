using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace MaterialRentalSysteem
{
    /// <summary>
    /// The SuperManager does all the logics and manages the different managers.
    /// </summary>
    class SuperManager
    {
        AccountManager accountManager;
        DataManager dataManager;
        ItemManager itemManager;
        RentalManager rentalManager;
        public SuperManager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
            itemManager = new ItemManager();
            rentalManager = new RentalManager();
        }
        /// <summary>
        /// Add an item to the database.
        /// </summary>
        /// <param name="info"></param>
        public void AddItem(List<string> info)
        {
            dataManager.SetItem(info);
        }
        /// <summary>
        /// Get all the items that are in the database.
        /// </summary>
        /// <returns></returns>
        public List<Item> GetAllItems()
        {
            RefreshItems();
            return itemManager.Items;
        }
        /// <summary>
        /// Return a list with all the items currently in the ItemManager
        /// </summary>
        /// <returns></returns>
        public List<Item> Update()
        {
            return itemManager.Items;
        }
        /// <summary>
        /// Get all the items that are in stock from the database
        /// </summary>
        /// <returns></returns>
        public List<Item> GetAvaillableItems()
        {
            RefreshItems();
            return itemManager.GetAvaillableItems();
        }
        /// <summary>
        /// Get all the items from the database and refresh the list held in the ItemManager.
        /// </summary>
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
        /// <summary>
        /// Get all the items that are rented out currently from the database.
        /// </summary>
        /// <returns></returns>
        public List<Rental> GetAllRentedItems()
        {
            rentalManager.RentedItems.Clear();
            List<Dictionary<string, string>> list = dataManager.GetAllRentedItems();
            Console.WriteLine(list);
            Rental rental;
            foreach (Dictionary<string, string> d in list)
            {
                rental = new Rental(Convert.ToInt32(d["ITEMRENTALID"]),
                    d["FULLNAME"], d["TYPEITEM"], d["NAME"], Convert.ToDateTime(d["STARTDATE"]),
                    Convert.ToDateTime(d["ENDDATE"]),Convert.ToInt32(d["TOTALAMOUNT"]),Convert.ToInt32(d["ITEMID"]));
                rentalManager.AddRental(rental);
            }
            return rentalManager.RentedItems;
        }
        /// <summary>
        /// Remove an item from the database.
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(Item item)
        {
            dataManager.DeleteItem(item.ID.ToString());
        }
        /// <summary>
        /// Get a specific item from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Item GetItem(string id)
        {
            List<Dictionary<string, string>> list = dataManager.GetItem(id);
            Console.WriteLine(list);
            Item item;
            foreach (Dictionary<string, string> d in list)
            {
                item = new Item(Convert.ToInt32(d["ITEMID"]), d["NAME"], d["TYPEITEM"], Convert.ToInt32(d["STOCK"]), Convert.ToDecimal(d["PRICE"]));
                return item;
            }
            return null;
        }
        /// <summary>
        /// Update an item in the database.
        /// </summary>
        /// <param name="newInfo"></param>
        /// <param name="id"></param>
        public void ChangeItem(List<string> newInfo,string id)
        {
            dataManager.UpdateItem(newInfo,id);
        }
        /// <summary>
        /// Delete an item from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(Item item)
        {
            string id = item.ID.ToString();
            dataManager.DeleteItem(id);
        }
        /// <summary>
        /// Search a person by RFID.
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Add a new rental, then connect it to a guest. Finally remove the rented item from the stock.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="guest"></param>
        /// <param name="EndDate"></param>
        /// <param name="amount"></param>
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

            //Remove amount from the stock
            int stock = item.Stock;
            stock -= Convert.ToInt32(amount);
            itemInfo.Add(item.Name);
            itemInfo.Add(item.Type);
            itemInfo.Add(stock.ToString());
            itemInfo.Add(item.Price.ToString());
            dataManager.UpdateItem(itemInfo, itemID);
        }
        /// <summary>
        /// Disconnect a person from a rental. The rental itself stays in the database as a record.
        /// </summary>
        /// <param name="ID"></param>
        public void TakeRental(string ID)
        {
             dataManager.DeleteItemRental(ID);
        }
        /// <summary>
        /// Get a list of all the guests that are currently present.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Search a person by a name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
        public List<Rental> SortBy(int index)
        {
            RentalComparer.SortByName SortByName = new RentalComparer.SortByName();
            RentalComparer.SortByType SortByType = new RentalComparer.SortByType();
            
            if(index == 0)
            {
                // sort rental by name
                rentalManager.RentedItems.Sort(SortByName);
                return rentalManager.RentedItems;
            }
            else if(index == 1)
            {
                //sort rental by type
                rentalManager.RentedItems.Sort(SortByType);
                return rentalManager.RentedItems;
            }
            return rentalManager.RentedItems;
        }
        public List<Rental> GetAllRentalsByRFID(string RFID)
        {
            
            rentalManager.RentedItems.Clear();
            List<Dictionary<string, string>> list = dataManager.GetRentedItemsByRFID(RFID);
            Console.WriteLine(list);
            Rental rental;
            foreach (Dictionary<string, string> d in list)
            {
                rental = new Rental(Convert.ToInt32(d["ITEMRENTALID"]),
                    d["FULLNAME"], d["TYPEITEM"], d["NAME"], Convert.ToDateTime(d["STARTDATE"]),
                    Convert.ToDateTime(d["ENDDATE"]),Convert.ToInt32(d["TOTALAMOUNT"]),Convert.ToInt32(d["ITEMID"]));
                rentalManager.AddRental(rental);
            }
            return rentalManager.RentedItems;
        }
    }
}

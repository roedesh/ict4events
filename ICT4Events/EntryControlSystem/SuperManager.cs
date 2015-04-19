using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;//From the Account library
using DataLibrary;//From the Data library

namespace EntryControlSystem
{
    
    class SuperManager
    {
         AccountManager accountManager;
         DataManager dataManager;
        

        public SuperManager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
        }
        /// <summary>
        /// Get a list off all guest that are present.
        /// </summary>
        /// <returns></returns>
        public List<Guest> ShowAllPresent()
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
        /// Call the appropriate method depending on wether idName is an int or a string. Then return the received list.
        /// </summary>
        /// <param name="idName"></param>
        /// <returns></returns>
        public List<Guest> ShowSearchedPerson(string idName)
        {
            int id = -1;
            bool succes = true;
            try
            {
                id = Convert.ToInt32(idName);
            }
            catch
            {
                succes = false;
            }
            if(succes)
            {
                return SearchPersonID(id);
            }
            else
            {
                return SearchPersonName(idName);
            }
        }
        /// <summary>
        /// Give a list of all guests with a certain id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Guest> SearchPersonID(int id)
        {
            List<Guest> persons = new List<Guest>();
            Guest account;
            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(id);
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
        /// Give a list of all guests with a certain name.
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
        /// <summary>
        /// Set a Guest to be either present or absent depending on his initial status
        /// </summary>
        /// <param name="GuestID"></param>
        /// <param name="AccountID"></param>
        /// <param name="RFID"></param>
        /// <param name="Presence"></param>
        /// <returns></returns>
        public bool UpdatePresence(string GuestID,string AccountID, string RFID, string Presence)
        {
            try
            {
                dataManager.UpdatePresence(GuestID, AccountID, RFID, Presence);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Check if somebody has paid his reservation
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public bool CheckPayment(string RFID)
        {
            string username = "";
            string paymentStatus = "";
            //GetUsername
            List<Dictionary<string, string>> list = dataManager.GetGuestAccountWithRFID(RFID);
            Console.WriteLine(list);
            foreach(Dictionary<string,string> d in list)
            {
                username = d["USERNAME"];
            }
            //get paymentstatus
            list = dataManager.GetPaymentStatus(username);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                paymentStatus = d["PAYMENTSTATUS"];
            }
            //check paymentstatus
            if (paymentStatus == "PAID")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Search a person by RFID
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

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
                                    d["ISPRESENT"]);
                presentPersons.Add(account);

            }
            return presentPersons;
        }
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
                                    d["ISPRESENT"]);
                persons.Add(account);

            }
            return persons;
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
                                    d["ISPRESENT"]);
                persons.Add(account);

            }
            return persons;
        }

        public bool SetPresence(string accountID,string YN)
        {
            try
            {
                dataManager.SetPresence(YN, accountID);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
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

        public List<Guest> GetUserInfo(string RFID)
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
                                    d["ISPRESENT"]);
                persons.Add(account);
            }
            return persons;
        }

        public void Test()
        {
            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(1);
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                Console.WriteLine(fullName);
            }
        }

    }
}

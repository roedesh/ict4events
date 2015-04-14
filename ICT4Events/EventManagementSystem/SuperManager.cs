using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace EventManagementSystem
{
    class SuperManager
    {
        private EventManager eventManager;
        private AccountManager accountManager;
        private DataManager dataManager;

        public SuperManager()
        {
            eventManager = new EventManager();
            accountManager = new AccountManager();
            dataManager = new DataManager();
        }

        public void AddEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(id));
            list.Add(location);
            list.Add(startdate);
            list.Add(enddate);
            list.Add(description);
            list.Add(Convert.ToString(admissionFee));
            dataManager.SetEvent(list);
        }

        public void EditEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(id));
            list.Add(location);
            list.Add(startdate);
            list.Add(enddate);
            list.Add(description);
            list.Add(Convert.ToString(admissionFee));
            dataManager.UpdateEvent(list);
            eventManager.EditEvent(id, location, startdate, enddate, description, admissionFee);
        }

        public void DeleteEvent(string id)
        {
            dataManager.DeleteEvent(id);
            eventManager.RemoveEvent(Convert.ToInt32(id));
        }

        public List<Event> ShowEvents()
        {
            List<Dictionary<string, string>> list = dataManager.GetAllEvents();
            foreach (Dictionary<string, string> d in list)
            {
                eventManager.AddEvent(Convert.ToInt32(d["EVENTID"]),d["LOCATION"], Convert.ToString(d["STARTDATE"]),
                   Convert.ToString(d["ENDDATE"]), d["DESCRIPTION"], Convert.ToDecimal(d["ADMISSIONFEE"]));
            }
            return eventManager.ShowEvents();

        }

        public void AddAccount(int accountID, int eventID, string username, string password, string fullname,
            string adress, string city, string postalcode, string dateofbirth, string email, int phonenumber,
            int guestID, string RFID, string IsPresent)
        {
            List<string> listAccount = new List<string>();
            listAccount.Add(Convert.ToString(accountID));
            listAccount.Add(Convert.ToString(eventID));
            listAccount.Add(username);
            listAccount.Add(password);
            listAccount.Add(fullname);
            listAccount.Add(adress);
            listAccount.Add(city);
            listAccount.Add(postalcode);
            listAccount.Add(dateofbirth);
            listAccount.Add(email);
            listAccount.Add(Convert.ToString(phonenumber));
            List<string> listGuest = new List<string>();
            listGuest.Add(Convert.ToString(guestID));
            listGuest.Add(Convert.ToString(accountID));
            listGuest.Add(RFID);
            listGuest.Add(IsPresent);
            dataManager.SetGuestAccount(listAccount, listGuest);
        }

        public void EditAccount()
        {
            
        }

        public List<Account> ShowAccounts() // string list return ipv void
        {
            List<Dictionary<string, string>> list = dataManager.GetAllGuests();
            foreach (Dictionary<string, string> d in list)
            {
                //Account a = new Account()
                //accountManager.AddAccount();

            }
            return accountManager.Accounts;
        }
    }
}

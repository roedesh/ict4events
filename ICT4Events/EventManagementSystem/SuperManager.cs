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

        public void EditEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            
        }

        public void DeleteEvent(string id)
        {
            dataManager.DeleteEvent(id);
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

        public void AddAccount(string name, string adress, string city, string postalCode)
        {
            
        }

        public void EditAccount()
        {
            
        }

        public List<string> ShowAccounts() // string list return ipv void
        {
            List<Dictionary<string, string>> list = dataManager.GetAllGuests();
            List<string> showAll = new List<string>();
            foreach (Dictionary<string, string> d in list)
            {
                showAll.Add(d["GUESTID"]);
                showAll.Add(d["ACCOUNTID"]);
                showAll.Add(d["RFID"]);
                showAll.Add(d["ISPRESENT"]);

            }
            return showAll;
        }
    }
}

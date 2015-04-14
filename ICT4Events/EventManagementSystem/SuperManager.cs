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

        public void AddEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            //eventManager.AddEvent(name, adress, city, postalCode, admissionFee);  --moet dit worden gedaan?
            List<string> eventList = new List<string>();
            eventList.Add(name);
            eventList.Add(adress);
            eventList.Add(city);
            eventList.Add(postalCode);
            eventList.Add(Convert.ToString(admissionFee));
            dataManager.SetEvent(eventList);
        }

        public void EditEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            //eventManager.EditEvent(name, adress, city, postalCode, admissionFee);
        }

        public void RemoveEvent(string name)
        {
            //eventManager.RemoveEvent(name);
            //dataManager.DeleteEvent(); -- hoe weet ik de id?
        }

        public List<Event> ShowEvents()
        {
            return eventManager.ShowEvents();
        }

        public void AddAccount(string name, string adress, string city, string postalCode)
        {
            List<string> acc = new List<string>();
            acc.Add(name);
            acc.Add(adress);
            acc.Add(city);
            acc.Add(postalCode);
           //dataManager.SetGuestAccount();
        }

        public void EditAccount()
        {
            
        }

        public List<string> ShowAccounts() // string list return ipv void
        {
            return dataManager.GetAllGuests();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace EventManagementSystem
{
    class SuperManager
    {
        private EventManager eventManager;
        private AccountManager accountManager;
        

        public SuperManager()
        {
            eventManager = new EventManager();
            accountManager = new AccountManager();
        }

        public void AddEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            eventManager.AddEvent(name, adress, city, postalCode, admissionFee);
        }

        public void EditEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            eventManager.EditEvent(name, adress, city, postalCode, admissionFee);
        }

        public void RemoveEvent(string name)
        {
            eventManager.RemoveEvent(name);
        }

        public List<Event> ShowEvents()
        {
            return eventManager.ShowEvents();
        }

        public void AddAccount(string name, string adress, string city, string postalCode)
        {
            //kijk nog even naar deze method. klopt wss niet.
        }

        public void EditAccount()
        {
            //kijk nog even naar deze method. klopt wss niet.
        }

        public void ShowAccounts()
        {
            //kijk nog even naar deze method. klopt wss niet.
        }
    }
}

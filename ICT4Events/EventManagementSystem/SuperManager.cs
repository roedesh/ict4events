using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class SuperManager
    {
        EventManager eventManager;
        

        public SuperManager()
        {
            eventManager = new EventManager();
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


    }
}

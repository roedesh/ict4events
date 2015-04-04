using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class EventManager
    {
        private List<Event> evnt;

        public EventManager()
        {
            evnt = new List<Event>();
        }

        public bool AddEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            foreach (Event e in evnt)
            {
                if(e.Name == name)
                {
                    return false;
                }
            }
            //If event doesn't exist
            Event ev = new Event(name, adress, city, postalCode, admissionFee);
            evnt.Add(ev);
            return true;
        }

        public bool RemoveEvent(string name)
        {
            //remove event
            return true;
        }

        public bool EditEvent(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            foreach (Event e in evnt)
            {
                //if event exists, edit the settings
                if(e.Name == name)
                {
                    e.Name = name;
                    e.Adress = adress;
                    e.City = city;
                    e.PostalCode = postalCode;
                    e.AdmissionFee = admissionFee;
                    return true;
                }
            }
            //if event doesn't exists return false
            return false; 
        }

        public List<Event> ShowEvents()
        {
            return evnt;
        }
    }
}

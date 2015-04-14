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

        public bool AddEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            foreach (Event e in evnt)
            {
                if(e.Id == id)
                {
                    return false;
                }
            }
            //If event doesn't exist
            Event ev = new Event(id, location, startdate, enddate, description, admissionFee);
            evnt.Add(ev);
            return true;
        }

        public bool RemoveEvent(string name)
        {
            //remove event
            return true;
        }

        public bool EditEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            foreach (Event e in evnt)
            {
                //if event exists, edit the settings
                if(e.Id == id)
                {
                    e.Id = id;
                    e.Location = location;
                    e.StartDate = startdate;
                    e.EndDate = enddate;
                    e.Description = description;
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

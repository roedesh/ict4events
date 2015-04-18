using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class LocationManager
    {
        private List<Location> location;

        public List<Location> Location
        {
            get { return location; }
            set { location = value; }
        }

        public LocationManager()
        {
            location = new List<Location>();
        }

        public bool EditLocation(int id, string name, string description, int price)
        {
            foreach (Location l in location)
            {
                //if event exists, edit the settings
                if (l.Id == id)
                {
                    l.Id = id;
                    l.Name = name;
                    l.Description = description;
                    l.Price = price;
                    return true;
                }
            }
            //if event doesn't exists return false
            return false;
        }

        public bool AddLocation(int id, string name, string description, int price)
        {
            foreach (Location l in location)
            {
                if (l.Id == id)
                {
                    return false;
                }
            }
            //If location doesn't exist
            Location lo = new Location(id, name, description, price);
            Location.Add(lo);
            return true;
        }


    }
}

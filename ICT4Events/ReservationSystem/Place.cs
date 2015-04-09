using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class Place
    {
        public int PublicID { get; private set; }
        public Type Type { get; private set; }

        public Place(int publicID, Type type)
        {
            PublicID = publicID;
            Type = type;
        }
    }
}

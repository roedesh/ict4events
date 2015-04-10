using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ReservationSystem
{
    class SuperManager
    {
        ReservationManager rManager = new ReservationManager();
        AccountManager aManager = new AccountManager();

        public SuperManager()
        {
        }

        public bool AddReservation(string naam, string city, DateTime dateOfBirth, int extraPersons, string email)
        {
            return true;
        }
    }
}

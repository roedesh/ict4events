using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ReservationSystem
{
    class Reservation
    {
        public int ReservationID { get; private set; }
        public Place Place { get; private set; }
        public List<Account> Accounts { get; private set; }

        public Reservation(int reservationID, Place place, List<Account> accounts)
        {
            ReservationID = reservationID;
            Place = place;
            Accounts = accounts;
        }

        public bool AddAccount(Account account){
            Account exists = Accounts.Find(a => a.ID == account.ID);
            if (exists != null)
                return false;
            Accounts.Add(account);
            return true;
        }

        public bool RemoveAccount(Account account)
        {
            return Accounts.Remove(account);
        }
    }
}

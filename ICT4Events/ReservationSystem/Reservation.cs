using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ReservationSystem
{
    public class Reservation
    {
        public int ReservationID { get; private set; }
        public int LocationID { get; private set; }
        public int TotalAmount { get; private set; }
        public string PaymentStatus { get; private set; }
        public List<Account> Accounts { get; private set; }

        public Reservation(int reservationID, int locationID, int totalAmount, string paymentStatus, List<Account> accounts)
        {
            ReservationID = reservationID;
            LocationID = locationID;
            TotalAmount = totalAmount;
            PaymentStatus = paymentStatus;
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

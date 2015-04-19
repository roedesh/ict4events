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

        public Reservation(int reservationID, int locationID, int totalAmount, string paymentStatus)
        {
            ReservationID = reservationID;
            LocationID = locationID;
            TotalAmount = totalAmount;
            PaymentStatus = paymentStatus;
        }
    }
}

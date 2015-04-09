using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;

namespace ReservationSystem
{
    class ReservationManager
    {
        List<Reservation> Reservations {get; private set;}

        public ReservationManager()
        {
            Reservations = new List<Reservation>();
        }

        public bool AddReservation(Reservation reservation)
        {
            Reservation exists = Reservations.Find(r => r.ReservationID == reservation.ReservationID);
            if (exists != null)
                return false;
            Reservations.Add(reservation);
            return true;
        }

        public bool DeleteReservation(Reservation reservation)
        {
            return Reservations.Remove(reservation);
        }

        public bool EditReservation(int ID)
        {

        }
    }
}

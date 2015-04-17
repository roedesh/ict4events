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
        public List<Reservation> Reservations {get; set;}

        public ReservationManager()
        {
            Reservations = new List<Reservation>();
        }

        /// <summary>
        /// Adds a reservation to Reservations
        /// </summary>
        /// <param name="reservation">Instance of Reservation class</param>
        /// <returns>true or false</returns>
        public bool AddReservation(Reservation reservation)
        {
            Reservation exists = Reservations.Find(r => r.ReservationID == reservation.ReservationID);
            if (exists != null)
                return false;
            Reservations.Add(reservation);
            return true;
        }

        /// <summary>
        /// Delete reservation from Reservations
        /// </summary>
        /// <param name="reservation">Instance of Reservation class</param>
        /// <returns>true or false</returns>
        public bool DeleteReservation(Reservation reservation)
        {
            return Reservations.Remove(reservation);
        }

        /// <summary>
        /// Return all Reservations
        /// </summary>
        /// <returns>List of Reservation objects</returns>
        public List<Reservation> ReturnReservations()
        {
            return Reservations;
        }
   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;
using System.ComponentModel;

namespace ReservationSystem
{
    public class SuperManager
    {
        ReservationManager rManager = new ReservationManager();
        AccountManager aManager = new AccountManager();
        DataManager dManager = new DataManager();

        /*  Temporary managers and accounts 
         *  Works as a link between the main form and "Add persons" form
         */
        public Account currentExistingAccount; // Holds the existing account that has been found in the "Add persons" form
        public Account mainBooker;
        public AccountManager tempAccountManager = new AccountManager();

        public SuperManager()
        {
        }

        /// <summary>
        /// Check if a location is not reserved
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true or false</returns>
        public bool CheckPlace(string number){
            return dManager.IsReserved(number);
        }

        /// <summary>
        /// Get account from database, search by ID
        /// </summary>
        /// <param name="ID">Account ID</param>
        /// <returns></returns>
        public Guest GetAccount(int ID)
        {
            List<Dictionary<string, string>> list = dManager.GetFreeGuestAccount(ID);
            Guest g = null;
            foreach (Dictionary<string, string> d in list)
            {
                g = new Guest(
                    Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToInt32(d["EVENTID"]),
                    d["USERNAME"],
                    d["PASSWORD"],
                    d["FULLNAME"],
                    d["ADRESS"],
                    d["CITY"],
                    d["POSTALCODE"],
                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                    d["EMAIL"],
                    d["PHONENUMBER"],
                    d["RFID"],
                    d["ISPRESENT"]
                    );
                aManager.AddAccount(g);
            }
            return g;
        }

        /// <summary>
        /// Get account from database, search by ID
        /// </summary>
        /// <param name="username">Accont username</param>
        /// <returns>Instance of Guest class</returns>
        public Guest GetAccount(string username)
        {
            List<Dictionary<string, string>> list = dManager.GetFreeGuestAccount(username);
            Guest g = null;
            foreach (Dictionary<string, string> d in list)
            {
                g = new Guest(
                    Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToInt32(d["EVENTID"]),
                    d["USERNAME"],
                    d["PASSWORD"],
                    d["FULLNAME"],
                    d["ADRESS"],
                    d["CITY"],
                    d["POSTALCODE"],
                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                    d["EMAIL"],
                    d["PHONENUMBER"],
                    d["RFID"],
                    d["ISPRESENT"]
                    );
                aManager.AddAccount(g); 
            }
            return g;
        }

        /// <summary>
        /// Add account to accountmanager
        /// </summary>
        /// <param name="a">Instance of Account class</param>
        public void AddAccount(Account a)
        {
            aManager.AddAccount(a);
        }

        /// <summary>
        /// Set reservation
        /// </summary>
        /// <param name="reservationParams">Field values for reservation table</param>
        /// <returns>ID of set reservation</returns>
        public int SetReservation(List<string> reservationParams)
        {
            int ID = dManager.SetReservation(reservationParams);
            return ID;
        }

        /// <summary>
        /// Create a new guest account in database
        /// </summary>
        /// <param name="accountParams">Field values for account table</param>
        /// <returns>ID of created account</returns>
        public int SetAccount(List<string> accountParams)
        {
            int accountID = dManager.SetGuestAccount(accountParams);
            return accountID;
        }

        /// <summary>
        /// Create new GuestReservation
        /// </summary>
        /// <param name="ID">ID of guest account</param>
        /// <param name="RID">reservation ID</param>
        public void SetGuestReservation(int ID, int RID)
        {
            dManager.SetGuestReservation(Convert.ToString(ID), Convert.ToString(RID));
        }

        /// <summary>
        /// Get reservations where fieldvalue matches the value parameter
        /// </summary>
        /// <param name="field">Name of the field</param>
        /// <param name="value">Value of the field</param>
        /// <returns>List of Reservation objects</returns>
        public BindingList<Reservation> GetReservations(string field, string value){
            List<Dictionary<string, string>> list = dManager.GetReservationByField(field, value);
            if (list.Count == 0)
            {
                return null;
            }
            BindingList<Reservation> reservations = new BindingList<Reservation>();
            foreach (Dictionary<string, string> d in list)
            {
                Reservation r = new Reservation(
                    Convert.ToInt32(d["RESERVATIONID"]),
                    Convert.ToInt32(d["LOCATIONID"]),
                    Convert.ToInt32(d["TOTALAMOUNT"]),
                    d["PAYMENTSTATUS"]
                );
                reservations.Add(r);
            }
            return reservations;
        }

        /// <summary>
        /// Delete reservation with given ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>true of false</returns>
        public bool DeleteReservation(string ID)
        {
            return dManager.DeleteReservation(ID);
        }

        public bool GetEvent(string ID)
        {
            List<Dictionary<string,string>> e = dManager.GetEvent(ID);
            if (e.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}

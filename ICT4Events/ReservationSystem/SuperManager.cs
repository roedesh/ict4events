using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace ReservationSystem
{
    public class SuperManager
    {
        ReservationManager rManager = new ReservationManager();
        AccountManager aManager = new AccountManager();
        DataManager dManager = new DataManager();

        public SuperManager()
        {
        }

        public bool CheckPlace(string number){
            return dManager.IsReserved(number);
        }

        public Guest GetAccount(int ID)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(ID);
            Guest g = null;
            foreach (Dictionary<string, string> d in list)
            {
                // Account opbouwen met de waardes uit de dictionary
                g = new Guest(
                    Convert.ToInt32(d["ACCOUNTID"]),
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
                aManager.AddAccount(g); // Voeg nieuwe gemaakte account toe aan accountmanager
            }
            return g;
        }

        public Guest GetAccount(string username)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(username);
            Guest g = null;
            foreach (Dictionary<string, string> d in list)
            {
                // Account opbouwen met de waardes uit de dictionary
                g = new Guest(
                    Convert.ToInt32(d["ACCOUNTID"]),
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
                aManager.AddAccount(g); // Voeg nieuwe gemaakte account toe aan accountmanager
            }
            return g;
        }
    }
}

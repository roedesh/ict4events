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

        public Account GetAccount(int ID)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(ID);
            Account a = null;
            foreach (Dictionary<string, string> d in list)
            {
                // Account opbouwen met de waardes uit de dictionary
                a = new Account(
                    Convert.ToInt32(d["ACCOUNTID"]), 
                    d["RFID"], 
                    d["FULLNAME"], 
                    d["ADRESS"], 
                    d["CITY"], 
                    d["POSTALCODE"], 
                    Convert.ToDateTime(d["DATEOFBIRTH"]), 
                    d["EMAIL"], 
                    d["PHONENUMBER"], 
                    Account.AccountRole.Guest);
                aManager.AddAccount(a); // Voeg nieuwe gemaakte account toe aan accountmanager
            }
            return a;
        }

        public Account GetAccount(string username)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(username);
            Account a = null;
            foreach (Dictionary<string, string> d in list)
            {
                // Account opbouwen met de waardes uit de dictionary
                a = new Account(
                    Convert.ToInt32(d["ACCOUNTID"]),
                    d["RFID"],
                    d["FULLNAME"],
                    d["ADRESS"],
                    d["CITY"],
                    d["POSTALCODE"],
                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                    d["EMAIL"],
                    d["PHONENUMBER"],
                    Account.AccountRole.Guest);
                aManager.AddAccount(a); // Voeg nieuwe gemaakte account toe aan accountmanager
            }
            return a;
        }
    }
}

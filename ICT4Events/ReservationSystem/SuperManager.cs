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

        public void GetAccount(int ID)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(ID);
            Account a;
            foreach (Dictionary<string, string> d in list)
            {
                // Account opbouwen met de waardes uit de dictionary
                a = new Account(
                    Convert.ToInt32(d["ID"]), 
                    d["RFID"], 
                    d["NAME"], 
                    d["ADDRESS"], 
                    d["CITY"], 
                    d["POSTALCODE"], 
                    Convert.ToDateTime(d["DATEOFBIRTH"]), 
                    d["EMAIL"], 
                    d["PHONE"], 
                    Account.AccountRole.Guest);
                aManager.AddAccount(a); // Voeg nieuwe gemaakte account toe aan accountmanager
            }
        }

        public void GetAccount(string username)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(username);
        }
    }
}

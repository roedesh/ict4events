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
            List<string> list = dManager.GetGuestAccount(ID);
            Console.WriteLine(list);
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
        }

        public void GetAccount(string username)
        {
            List<string> list = dManager.GetGuestAccount(username);
        }
    }
}

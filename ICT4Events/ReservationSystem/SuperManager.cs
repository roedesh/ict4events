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
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                Console.WriteLine(d["USERNAME"]);
            }
        }

        public void GetAccount(string username)
        {
            List<Dictionary<string, string>> list = dManager.GetGuestAccount(username);
        }
    }
}

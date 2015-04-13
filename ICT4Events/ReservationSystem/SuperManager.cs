using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace ReservationSystem
{
    class SuperManager
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

    
    }
}

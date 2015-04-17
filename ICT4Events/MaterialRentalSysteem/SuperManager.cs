using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace MaterialRentalSysteem
{
    class SuperManager
    {
        AccountManager accountManager;
        DataManager dataManager;
        public SuperManager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
        }
        public void AddItem(List<string> info)
        {
            dataManager.SetItem(info);
        }

    }
}

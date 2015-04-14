using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace EntryControlSystem
{
    
    class SuperManager
    {
        private AccountManager accountManager;
        private DataManager dataManager;
        List<string> presentGuests;

        public void SuperMager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
            presentGuests = new List<string>();
        }
        public List<string> ShowAllPresent()
        {
            presentGuests = dataManager.GetAllGuests();
            return presentGuests;
        }
        public List<string> ShowSearchedPerson(string idName)
        {
            int id = -1;
            bool succes = true;
            try
            {
                id = Convert.ToInt32(idName);
            }
            catch
            {
                succes = false;
            }
            if(succes)
            {
                return SearchPersonID(id);
            }
            else
            {
                return SearchPersonName(idName);
            }
        }
        public List<string> SearchPersonID(int id)
        {
            return dataManager.GetGuestAccount(id);
        }
        public List<string> SearchPersonName(string name)
        {
            return dataManager.GetGuestAccount(name);
        }

        public bool SetPresence(int accountID)
        {
            return true;
        }

    }
}

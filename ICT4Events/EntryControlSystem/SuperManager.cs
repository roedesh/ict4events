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
        

        public SuperManager()
        {
            accountManager = new AccountManager();
            dataManager = new DataManager();
        }
        public List<string> ShowAllPresent()
        {
            List<string> presentGuests = new List<string>();
            string userInfo = "";
            List<Dictionary<string, string>> list = dataManager.GetAllGuests();
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                string isPresent = d["ISPRESENT"];
                string RFID = d["RFID"];
                userInfo = fullName + " , " + isPresent + " , " + RFID;
                presentGuests.Add(userInfo);
            }
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
            List<string> persons = new List<string>();
            string userInfo = "";
            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(id);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                string isPresent = d["ISPRESENT"];
                string RFID = d["RFID"];
                userInfo = fullName + " , " + isPresent + " , " + RFID;
                persons.Add(userInfo);
            }
            return persons;
        }
        public List<string> SearchPersonName(string name)
        {
            List<string> persons = new List<string>();
            string userInfo = "";
            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(name);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                string isPresent = d["ISPRESENT"];
                string RFID = d["RFID"];
                userInfo = fullName + " , " + isPresent + " , " + RFID;
                persons.Add(userInfo);
            }
            return persons;
        }

        public bool SetPresence(int accountID)
        {
            return true;
        }
        
        public bool CheckPayment(string RFID)
        {
            string username = "";
            string paymentStatus = "";
            //GetUsername
            List<Dictionary<string, string>> list = dataManager.GetGuestAccountWithRFID(RFID);
            Console.WriteLine(list);
            foreach(Dictionary<string,string> d in list)
            {
                username = d["USERNAME"];
            }
            //get paymentstatus
            list = dataManager.GetPaymentStatus(username);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                paymentStatus = d["PAYMENTSTATUS"];
            }
            //check paymentstatus
            if (paymentStatus == "PAID")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetUserInfo(string RFID)
        {
            string userInfo = "";
            //GetUsername
            List<Dictionary<string, string>> list = dataManager.GetGuestAccountWithRFID(RFID);
            Console.WriteLine(list);
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                string isPresent = d["ISPRESENT"];
                userInfo = fullName + " , " + isPresent;
            }
            return userInfo;
        }

        public void test()
        {
            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(1);
            foreach (Dictionary<string, string> d in list)
            {
                string fullName = d["FULLNAME"];
                Console.WriteLine(fullName);
            }
        }

    }
}

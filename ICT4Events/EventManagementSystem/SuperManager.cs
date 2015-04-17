using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using DataLibrary;

namespace EventManagementSystem
{
    class SuperManager
    {
        private EventManager eventManager;
        private AccountManager accountManager;
        private DataManager dataManager;

        public SuperManager()
        {
            eventManager = new EventManager();
            accountManager = new AccountManager();
            dataManager = new DataManager();
        }

        public void AddEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(id));
            list.Add(location);
            list.Add(startdate);
            list.Add(enddate);
            list.Add(description);
            list.Add(Convert.ToString(admissionFee));
            dataManager.SetEvent(list);
        }

        public void EditEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(id));
            list.Add(location);
            list.Add(startdate);
            list.Add(enddate);
            list.Add(description);
            list.Add(Convert.ToString(admissionFee));
            dataManager.UpdateEvent(list);
            eventManager.EditEvent(id, location, startdate, enddate, description, admissionFee);
        }

        public void DeleteEvent(string id)
        {
            dataManager.DeleteEvent(id);
            eventManager.RemoveEvent(Convert.ToInt32(id));
        }

        public List<Event> ShowEvents()
        {
            List<Dictionary<string, string>> list = dataManager.GetAllEvents();
            foreach (Dictionary<string, string> d in list)
            {
                eventManager.AddEvent(Convert.ToInt32(d["EVENTID"]),d["LOCATION"], Convert.ToString(d["STARTDATE"]),
                   Convert.ToString(d["ENDDATE"]), d["DESCRIPTION"], Convert.ToDecimal(d["ADMISSIONFEE"]));
            }
            return eventManager.ShowEvents();

        }

        public List<Account> ShowGuestAccounts()
        {
            accountManager.Accounts.Clear();
            List<Dictionary<string, string>> list = dataManager.GetAllGuests();
            foreach (Dictionary<string, string> d in list)
            {
                Account a = new Guest(Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToInt32(d["EVENTID"]), 
                    d["USERNAME"], d["PASSWORD"], 
                    d["FULLNAME"], d["ADRESS"], 
                    d["CITY"], d["POSTALCODE"], 
                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                    d["EMAIL"], d["PHONENUMBER"], d["RFID"],
                    d["ISPRESENT"]);
                accountManager.AddAccount(a);
            }
            return accountManager.Accounts;
        }

        public List<Employee> ShowEmployeeAccounts() 
        {
            accountManager.Employees.Clear();
            List<Dictionary<string, string>> list = dataManager.GetAllEmployees();
            foreach (Dictionary<string, string> d in list)
            {
                Account a = new Employee(Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToInt32(d["EVENTID"]),
                    d["USERNAME"], d["PASSWORD"],
                    d["FULLNAME"], d["ADRESS"],
                    d["CITY"], d["POSTALCODE"],
                    Convert.ToDateTime(d["DATEOFBIRTH"]),
                    d["EMAIL"], d["PHONENUMBER"],
                    (AccountLibrary.Employee.AccountRole)Enum.Parse(typeof(AccountLibrary.Employee.AccountRole), d["ROLENAME"]));

                accountManager.AddAccountE((Employee)a);
            }
            return accountManager.Employees;
        }

        public void EditGuest(int id, int eventId, string username, string password, string fullname,
            string address, string city, string postalcode, string dateOfBirth, string email,
            int phonenumber)
        {
            //create account list
            List<string> ac = new List<string>();
            ac.Add(Convert.ToString(id));
            ac.Add(Convert.ToString(eventId));
            ac.Add(username);
            ac.Add(password);
            ac.Add(fullname);
            ac.Add(address);
            ac.Add(city);
            ac.Add(postalcode);
            ac.Add(dateOfBirth);
            ac.Add(email);
            ac.Add(Convert.ToString(phonenumber));
            //send items to datamanager
            dataManager.UpdateAccount(ac);

        }

        public void EditEmployee(int id, int eventId, string username, string password, string fullname,
            string address, string city, string postalcode, string dateOfBirth, string email,
            int phonenumber, int employeeID, int roleID)
        {
            //create account list
            List<string> ac = new List<string>();
            ac.Add(Convert.ToString(id));
            ac.Add(Convert.ToString(eventId));
            ac.Add(username);
            ac.Add(password);
            ac.Add(fullname);
            ac.Add(address);
            ac.Add(city);
            ac.Add(postalcode);
            ac.Add(dateOfBirth);
            ac.Add(email);
            ac.Add(Convert.ToString(phonenumber));

            List<string> acEmpl = new List<string>();
            acEmpl.Add(Convert.ToString(id));
            acEmpl.Add(Convert.ToString(employeeID));
            acEmpl.Add(Convert.ToString(roleID));
            //send items to datamanager
            dataManager.UpdateAccount(ac);
            dataManager.UpdateEmployee(acEmpl);
        }

        public void AddEmployee(int id, int eventId, string username, string password, string fullname,
            string address, string city, string postalcode, string dateOfBirth, string email,
            int phonenumber, int employeeID, int roleID)
        {
            //create account list
            List<string> ac = new List<string>();
            ac.Add(Convert.ToString(id));
            ac.Add(Convert.ToString(eventId));
            ac.Add(username);
            ac.Add(password);
            ac.Add(fullname);
            ac.Add(address);
            ac.Add(city);
            ac.Add(postalcode);
            ac.Add(dateOfBirth);
            ac.Add(email);
            ac.Add(Convert.ToString(phonenumber));

            List<string> acEmpl = new List<string>();
            acEmpl.Add(Convert.ToString(id));
            acEmpl.Add(Convert.ToString(employeeID));
            acEmpl.Add(Convert.ToString(roleID));
            //send items to datamanager
            dataManager.UpdateAccount(ac);
            dataManager.UpdateEmployee(acEmpl);
        }

        public void DeleteAccountGuest(int accountID)
        {
            dataManager.DeleteGuest(Convert.ToString(accountID));

        }

        public void DeleteAccountEmployee(int accountID)
        {
            dataManager.DeleteEmployee(Convert.ToString(accountID));
        }
    }
}

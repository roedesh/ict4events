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

        public bool AddEvent(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            foreach (Event e in eventManager.Evnt)
            {
                if (e.Id == id)
                {
                    throw new MyException("Event id is in gebruik");
                }
            }

            if (Convert.ToDateTime(startdate) > Convert.ToDateTime(enddate))
            {
                throw new MyException("De startdatum mag niet na de einddatum zijn");
            }
            List<string> list = new List<string>();
            list.Add(Convert.ToString(id));
            list.Add(location);
            list.Add(startdate);
            list.Add(enddate);
            list.Add(description);
            list.Add(Convert.ToString(admissionFee));
            dataManager.SetEvent(list);
            return true;
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

        public bool AddEmployee(int id, int eventId, string username, string password, string fullname,
            string address, string city, string postalcode, string dateOfBirth, string email,
            int phonenumber, int employeeID, int roleID)
        {
            foreach (Employee e in accountManager.Employees.Concat(accountManager.Accounts))
            {
                if (e.ID == id)
                {
                    throw new MyException("Account id is in gebruik");
                }
                //if (e.employeeID == employeeID)
                //{
                //  throw new MyException("Employee id is in gebruik");
                //}
                if (e.Username == username)
                {
                    throw new MyException("Username is in gebruik");
                }
            }
            
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
            dataManager.SetEmployeeAccount(ac, acEmpl);

            return true;
        }

        public bool DeleteAccountGuest(int accountID)
        {
            foreach (Account a in accountManager.Accounts)
            {
                if (a.ID == accountID)
                {
                    dataManager.DeleteGuest(Convert.ToString(accountID));
                    return true;
                }
            }
            throw new MyException("Geen gast gevonden met account id: " + accountID);
        }

        public bool DeleteAccountEmployee(int accountID)
        {
            
            foreach (Account a in accountManager.Accounts)
            {
                if (a.ID == accountID)
                {
                    dataManager.DeleteEmployee(Convert.ToString(accountID));
                    return true;
                }
            }
            throw new MyException("Geen medewerker gevonden met account id: " + accountID);
        }

        public List<string> ShowLocations()
        {
            return null;
        }

        public int getEnum(string s)
        {
            return (int)(AccountLibrary.Employee.AccountRole)Enum.Parse(typeof(AccountLibrary.Employee.AccountRole), s);
        }
    }
}

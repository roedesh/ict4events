using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public abstract class Account
    {
        private int id;
        private int eventId;
        private string username;
        private string password;
        private string name;
        private string address;
        private string city;
        private string postalCode;
        private DateTime dateOfBirth;
        private string email;
        private string phone;

        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public int EventID {
            get { return eventId; }
            set { eventId = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Main constructor for full accounts
        public Account(int id, int eventId, string username, string password, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone)
        {
            ID = id;
            EventID = eventId;
            Username = username;
            Password = password;
            Name = name;
            Address = address;
            City = city;
            PostalCode = postalCode;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
        }

        // Smaller constructor for temporary accounts in the ExtraPersonsForm
        public Account(string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone)
        {
            ID = 0;
            Name = name;
            Address = address;
            City = city;
            PostalCode = postalCode;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
        }

        public abstract override string ToString();

        public string DateToString()
        {
            return DateOfBirth.ToShortDateString();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class Account
    {
        /* 
         *  The enum is called AccountRole instead of Role, 
         *  because there would be a name clash with the Role property.
         *       
         *  In a Form you can call this enum like this: Account.AccountRole.<Role>
        */
        public enum AccountRole
        {
            EventManager,
            ReservationManager,
            AccessManager,
            EntryManager,
            SocialMediaManager,
            Admin,
            Guest
        };

        private int id;
        private string rfid;
        private string name;
        private string address;
        private string city;
        private string postalCode;
        private DateTime dateOfBirth;
        private string email;
        private string phone;
        private AccountRole role;

        public AccountRole Role
        {
            get { return role; }
            set { role = value; }
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

        public string RFID
        {
            get { return rfid; }
            set { rfid = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Account(int id, string rfid, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone, AccountRole role)
        {
            ID = id;
            RFID = rfid;
            Name = name;
            Address = address;
            City = city;
            PostalCode = postalCode;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            Role = role;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1} - {2} - {3}", ID, Name, DateOfBirth.ToShortDateString(), Role);
        }

    }
}

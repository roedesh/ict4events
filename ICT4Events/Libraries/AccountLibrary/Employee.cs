using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Employee : Account
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

        private AccountRole role;

        public AccountRole Role
        {
            get { return role; }
            set { role = value; }
        }
        
        public Employee(int id, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone, AccountRole role)
            : base(id, name, address, city, postalCode, dateOfBirth, email, phone)
        {
            Role = role;
        }

        public Employee(string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone)
            : base(name, address, city, postalCode, dateOfBirth, email, phone)
        {
        }
    }
}

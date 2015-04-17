using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Guest : Account
    {
        private string isPresent;
        private string rfid;
        private int guestID;

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        
        
        public string IsPresent
        {
            get { return isPresent; }
            set { isPresent = value; }
        }
        
        public string RFID
        {
            get { return rfid; }
            set { rfid = value; }
        }
        
        public Guest(int id, int eventId, string username, string password, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone, string rfid, string isPresent)
            : base(id, eventId, username, password, name, address, city, postalCode, dateOfBirth, email, phone)
        {
            RFID = rfid;
            IsPresent = isPresent;
        }

        // Extra constructor to include guestID
        public Guest(int id, int eventId, string username, string password, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone, string rfid, string isPresent, int guestID)
            : base(id, eventId, username, password, name, address, city, postalCode, dateOfBirth, email, phone)
        {
            RFID = rfid;
            IsPresent = isPresent;
            GuestID = guestID;
        }


        public Guest(int eventId, string username, string password, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone)
            : base(eventId, username, password, name, address, city, postalCode, dateOfBirth, email, phone)
        {
        }

        public override string ToString()
        {
            if (ID == 0) // This is a temporary account
            {
                return String.Format("NIEUW ACCOUNT: {0}, {1}, {2}, {3}, {4}. {5}", Name, Address, City, PostalCode, Email, Phone);
            }
            return String.Format("{0} : {1} - {2} - {3} - {4}", ID, Name, DateOfBirth.ToShortDateString(), RFID, IsPresent);
        }
    }
}

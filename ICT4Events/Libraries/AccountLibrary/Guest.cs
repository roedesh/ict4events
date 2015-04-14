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
        
        public Guest(int id, string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone, string rfid, string isPresent)
            : base(id, name, address, city, postalCode, dateOfBirth, email, phone)
        {
            RFID = rfid;
            IsPresent = isPresent;
        }


        public Guest(string name, string address, string city, string postalCode,
                       DateTime dateOfBirth, string email, string phone)
            : base(name, address, city, postalCode, dateOfBirth, email, phone)
        {
        }
    }
}

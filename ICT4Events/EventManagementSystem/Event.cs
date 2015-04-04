using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class Event
    {

        public string Name
        {
            get;
            set;
        }

        public string Adress
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string PostalCode
        {
            get;
            set;
        }

        public decimal AdmissionFee
        {
            get;
            set;
        }


        public Event(string name, string adress, string city, string postalCode, decimal admissionFee)
        {
            Name = name;
            Adress = adress;
            City = city;
            PostalCode = postalCode;
            AdmissionFee = admissionFee;
        }

        public override string ToString()
        {
            return Name + Adress + City + PostalCode + AdmissionFee;
        }


    }
}

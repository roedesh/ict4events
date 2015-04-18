using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class Event
    {
        public int Id
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public string StartDate
        {
            get;
            set;
        }

        public string EndDate
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public decimal AdmissionFee
        {
            get;
            set;
        }

        public Event(int id, string location, string startdate, string enddate, string description, decimal admissionFee)
        {
            Id = id;
            Location = location;
            StartDate = startdate;
            EndDate = enddate;
            Description = description;
            AdmissionFee = admissionFee;
        }

        public override string ToString()
        {
            return Id + Location + StartDate + EndDate + Description + AdmissionFee;
        }


    }
}

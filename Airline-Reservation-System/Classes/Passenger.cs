using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System.Classes
{
    internal class Passenger
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNumber { get; set; }

        public Passenger() { }

        public Passenger(int iD, string fullName, string phoneNumber, string iDNumber)
        {
            ID = iD;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            IDNumber = iDNumber;
        }
    }
}

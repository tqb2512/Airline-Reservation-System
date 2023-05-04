using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System.Classes
{
    internal class Route
    {
        public int ID;
        public int Departure;
        public int Arrival;
        public int FligtTime;

        public Route() { }

        public Route(int iD, int departure, int arrival, int fligtTime)
        {
            ID = iD;
            Departure = departure;
            Arrival = arrival;
            FligtTime = fligtTime;
        }
    }
}

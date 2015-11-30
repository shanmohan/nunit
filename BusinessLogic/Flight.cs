﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Flight
    {
        public String FlightModel { get; set; }
        public bool IsLongHaul { get; set; }

        public int getFlightDuration(int leg1, int leg2){
            return leg1 + leg2;
        }

        public String formatFlightNumber(String airlineCode, String flightNumber)
        {
            return String.Concat(airlineCode, flightNumber);
        }

    }
}

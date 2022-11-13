using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDBConnection
{
    public class Facility
    {
        public int Fac_No { get; set; }
        public string  Fac_Name { get; set; }

        public int Hotel_No { get; set; }

        public override string ToString()
        {
            return $"ID: {Fac_No}, Name: {Fac_Name}, Location(Hotel Number): {Hotel_No}"; 
        }
    }
}

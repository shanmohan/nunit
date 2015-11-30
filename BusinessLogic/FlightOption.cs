using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FlightOption
    {

        public FlightOption()
        {
            this.Amenities = new List<string>();
        }
        public Flight Flight { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public List<String> Amenities { get; set; }

        public void SetAmenities()
        {                   
            this.Amenities.Add("Inflight Entertainment");
            this.Amenities.Add("Bar");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rome.BusinessEntities;
using Rome.RepositoryAccess;

namespace BusinessLogic
{
    public class FlightService
    {
        #region Private Variables
        private IFlightRepository flightRepository { get; set; }

        #endregion

        #region Constructors
        public FlightService()
        {
            flightRepository = new FlightRepository();
        }

        public FlightService(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }
        #endregion

        #region Public Properties
        public String FlightModel { get; set; }
        public bool IsLongHaul { get; set; }

        #endregion

        #region Public Methods
        public int GetFlightDuration(int leg1, int leg2)
        {
            return leg1 + leg2;
        }

        public String FormatFlightNumber(String airlineCode, String flightNumber)
        {
            return String.Concat(airlineCode, flightNumber);
        }

        public FlightEntity GetFlight()
        {
            System.Diagnostics.Debug.WriteLine("getFlight is being called from BusinessLogic layer ");
            var flightEntiry = flightRepository.getFlight();
            flightEntiry.Model = "Airbus";
            return flightEntiry;
        }

        public void UpdateFlightDetails()
        {
            throw new NullReferenceException();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rome.BusinessEntities;


namespace Rome.RepositoryAccess
{
    public class FlightRepository  : IFlightRepository
    {

        #region Private Variables
        private FlightEntity flightEntity;
        #endregion

        #region Constructors
        public FlightRepository()
        {
            flightEntity = new FlightEntity();
        }
        #endregion

        #region Public Methods
        public FlightEntity getFlight()
        {
            System.Diagnostics.Debug.WriteLine("getFlight is being called from Repository layer ");
            flightEntity.FlightNumber = "EK12345";
            flightEntity.Model = "Boweying 777";
            return flightEntity;
        }
        #endregion


    }
}

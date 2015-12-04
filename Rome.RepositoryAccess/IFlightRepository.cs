using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rome.BusinessEntities;

namespace Rome.RepositoryAccess
{
    public interface IFlightRepository
    {
        FlightEntity getFlight();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.ReadModels
{
    public record FlightRm(
        Guid Id, 
        string Airline,
        string Price,
        TimePlaceRm Departure,
        TimePlaceRm Arrival,
        int RemainingNumberOfSeats

        );
}

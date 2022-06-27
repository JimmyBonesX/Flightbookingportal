using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Dtos
{
    public record BookDto(Guid FlightId,
        string PassengerEmail,
        byte NumberOfSeats);
}

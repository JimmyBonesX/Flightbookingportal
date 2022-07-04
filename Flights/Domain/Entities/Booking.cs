using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flights.Domain.Entities
{
    public record Booking(
         string PassengerEmail,
         byte NumberOfSeats);
}

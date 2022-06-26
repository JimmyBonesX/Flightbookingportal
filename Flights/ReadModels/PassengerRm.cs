using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.ReadModels
{
    public record PassengerRm(
        string Email,
        string FirstName,
        string LastName,
        bool Gender);
}

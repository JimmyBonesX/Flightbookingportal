using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Dtos
{
    public record NewPassengerDto(string Email, string FirstName, string LastName, bool Gender);

}

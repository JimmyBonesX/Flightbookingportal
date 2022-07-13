using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.Dtos
{
    public record FlightSearchParameters(

        [DefaultValue("12/25/2022 10:30:00 AM")]
        DateTime? FromDate,

        [DefaultValue("12/26/2022 10:30:00 AM")]
        DateTime? ToDate,

        [DefaultValue("Los Angeles")]
        string? From,

        [DefaultValue("Warsaw")]
        string? Destination,

        [DefaultValue(1)]
        int? NumberOfPassengers
        );
   
}

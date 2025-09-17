using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class AirCraftRoute
    {
        public int Num_Of_Passenger { get; set; }

        public decimal Price { get; set; }

        public string? Departure { get; set; }

        public string? Duration { get; set; }

        public string? Arrival { get; set; }


        public int AirCraftId { get; set; }
        public AirCraft? AirCraftRoutNav  { get; set; }

        public int RouteId { get; set; }
        public Route? RouteNav { get; set; }
    }
}

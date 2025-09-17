using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Route
    {
        public int Id { get; set; }
        public string? Orgin { get; set; }

        public string? Distance { get; set; }

        public string? Destination { get; set; }

        public string? Classification { get; set; }

        public ICollection<AirCraftRoute> AirCraftRoutes02 { get; set; } = null!;
    }
}

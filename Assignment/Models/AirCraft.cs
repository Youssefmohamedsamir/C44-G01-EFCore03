using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class AirCraft
    {
        public int Id { get; set; }

        public int capacity { get; set; }

        public string? Model { get; set; }




        public int AilineId { get; set; }
        public Airline AirlineTable { get; set; } = null!;


        public ICollection<AirCraftRoute> AirCraftNav { get; set; } = new HashSet<AirCraftRoute>();

        public Crew CrewNav { get; set; } = null!;

    }
}

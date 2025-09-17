using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Crew
    {
        public string? Maj_Pilot { get; set; }

        public string? Assis_Pilot { get; set; }

        public int Host1 { get; set; }

        public int Host2 { get; set; }

        public int AirCraftId { get; set; }
        public AirCraft AirCraftNav02 { get; set; } = null! ;

        


    }
}

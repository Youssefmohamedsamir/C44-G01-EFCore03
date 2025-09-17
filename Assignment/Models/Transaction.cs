using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public string? Description { get; set; }


        public int AirlineId { get; set; }
        public Airline AirNav { get; set; } = null!;

    }
}

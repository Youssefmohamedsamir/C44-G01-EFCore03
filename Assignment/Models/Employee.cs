using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Qualifications { get; set; }

        public string? Address { get; set; }

        public string? Day { get; set; }

        public char Gender { get; set; }

        public string? Position { get; set; }







        public int AirEmpId { get; set; }         
        public Airline AirEmp { get; set; } = null!;
    }



}

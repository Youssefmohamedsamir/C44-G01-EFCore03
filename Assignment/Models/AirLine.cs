using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Airline
    {
        public int AirlineId { get; set; }

        public string? Name { get; set; }

        public string? Contact_Person { get; set; }

        public string? Address { get; set; }

        public int Phones { get; set; }




        [InverseProperty(nameof(Employee.AirEmp))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();


        [InverseProperty(nameof(AirCraft.AirlineTable))]
       public ICollection<AirCraft> AirCrafts { get; set; } = new HashSet<AirCraft>();


        [InverseProperty(nameof(Transaction.AirNav))]
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();

    }
}

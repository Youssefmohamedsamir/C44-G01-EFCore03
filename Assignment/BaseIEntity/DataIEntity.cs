using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BaseIEntity
{
    internal class DataIEntity : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {

            //builder.HasData(


            //new Employee()
            //{
            //    Id = 1,
            //    Name = "Youssef Mohamed",
            //    Position = "Pilot",
            //},
            //new Employee()
            //  {
            //      Id = 2,
            //      Name = "Ahme Bihbity",
            //      Position = "breaker",
            //  }
            //  ,
            //new Employee()
            //    {
            //        Id = 3,
            //        Name = "Torky",
            //        Position = "Programmer",
            //    }

            //);
                
        }
    }
}

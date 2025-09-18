using Assignment.DataContext;
using Assignment.Models;
using Microsoft.IdentityModel.Tokens;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BaseContext context = new BaseContext();

            #region Using Data Seeding Manuals

            List<Employee> Emp01 = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "John Doe",
                    Position = "Pilot",
                    Gender = 'M',
                    AirEmpId = 2,
                    Day = "Monday",
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Position = "Co-Pilot",
                    Gender = 'M',
                    AirEmpId = 3
                },
   
            };

            if (!context.Set<Employee>().Any())
            {
                context.Set<Employee>().AddRange(Emp01);
                context.SaveChanges();
            }



            #endregion





        }
    }
}

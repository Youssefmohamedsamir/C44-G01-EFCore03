using Assignment.DataContext;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BaseContext context = new BaseContext();

            #region Using Data Seeding Manuals

            //List<Employee> Emp01 = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id = 1,
            //        Name = "John Doe",
            //        Position = "Pilot",
            //        Gender = 'M',
            //        AirEmpId = 2,
            //        Day = "Monday",
            //    },
            //    new Employee()
            //    {
            //        Id = 2,
            //        Name = "Jane Smith",
            //        Position = "Co-Pilot",
            //        Gender = 'M',
            //        AirEmpId = 3
            //    },

            //};

            //if (!context.Set<Employee>().Any())
            //{
            //    context.Set<Employee>().AddRange(Emp01);
            //    context.SaveChanges();
            //}



            #endregion


            #region EFCore04 Q1


            //1.Load "EgyptAir" With all its aircrafts and their routes

            //var Result = context.Set<Airline>()
            //    .Where(R => R.Name == "EgyptAir")
            //    .Select(a => new
            //    {
            //        AirlineName = a.Name,
            //        AirCraft = a.AirCrafts
            //        .Select(b => new
            //        {
            //            Models = b.Model,
            //            Routess = b.AirCraftNav

            //        .Select(a => new
            //        {
            //            route = a.RouteNav.Id
            //        }).ToList()

            //        }).ToList()

            //    }).FirstOrDefault();




            //if (Result != null)
            //{
            //    Console.WriteLine($"Airline: {Result.AirlineName}");

            //    foreach (var ac in Result.AirCraft)
            //    {
            //        Console.WriteLine($"  Aircraft: {ac.Models}");
            //        foreach (var route in ac.Routess)
            //        {
            //            Console.WriteLine($"Route:{route} => {route}");
            //        }
            //    }
            //}


            #endregion

            #region EFcore04 Q2

            //Retrieve all airlines with their employees, and for each
            //employee load their qualifications.

            //var Result = context.Set<Airline>().Include(a => a.Employees).ThenInclude(E=>E.Qualifications).ToList();

            //if (Result is not null)
            //{

            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"All AirLines is {item}");


            //        foreach (var item01 in item.Employees)
            //        {
            //            Console.WriteLine($"All Employee is {item01}");

            //            if (item01.Qualifications is not null)
            //            {
            //                foreach (var item02 in item01.Qualifications)
            //                {
            //                    Console.WriteLine($"All Qualification is {item02}");
            //                }
            //            }

            //        }

            //    }


            //}


            #endregion

            #region EFcore04 Q3

            //Load all airlines with their transactions, but only include
            //transactions where Amount > 10000


            //var Result = context.Set<Airline>().Include(a => a.Transactions.Where(T => T.Amount > 10000)).ToList();


            //if (Result is not null)
            //{
            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"Their Name Airline is {item.Name}");


            //        foreach (var item01 in item.Transactions)
            //        {
            //            Console.WriteLine($"Your Transaction Id IS {item01.Id} and Their Description Transaction is {item01.Description} ");

            //        }

            //    }
            //}





            #endregion

            #region EFCore04 Q4

            //Select all routes along with the model of aircrafts assigned
            //to them

            //var Result = context.Set<Route>().Include(R => R.AirCraftRoutes02).ThenInclude(T => T.AirCraftRoutNav.Model)
            //    .Select(a => new{

            //        RouteId = a.Id,
            //        AirCraftModels = a.AirCraftRoutes02.Select(e => e.AirCraftRoutNav.Model)

            //    }).ToList();

            //Console.WriteLine();


            //if ( Result is not null)
            //{
            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"Result Of RouteId is {item.RouteId}");

            //        foreach (var item1 in item.AirCraftModels)
            //        {
            //            Console.WriteLine($"The Model that Assigned with aircraftModels Is {item1}");
            //        }

            //    }
            //}




            #endregion

            #region EFcore04 Q5

            //Retrieve all aircrafts with their airline and the airline’s
            //phones.


            //var Result = context.Set<AirCraft>().Include(a => a.AirlineTable).ThenInclude(T => T.Phones).ToList();

            //if (Result is not null)
            //{

            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"The AirCraftId is {item.Id}");


            //            foreach (var phone in item.AirlineTable.Phones)
            //            {
            //                Console.WriteLine($"Phone of AirCraftId {item.Id} is {phone.Number}");
            //            }


            //    }



            //  }





            #endregion

            #region EFCore06 Q6
            //1.List all employees with their airline name. 

            var Result = context.Set<Employee>()
              .Select(e => new
              {
                EmployeeName = e.Name,
                AirlineName = e.AirEmp.Name
              }).ToList();

            foreach (var emp in Result)
            {
                Console.WriteLine($"{emp.EmployeeName} works at {emp.AirlineName}");
            }

            #endregion

            #region EFcore07 Q7


            // Show all routes with the aircraft model assigned and the
            //airline name that owns the aircraft.

            //        var routes = context.Set<Route>().Include(a => a.AirCraftRoutes02).ThenInclude(T => T.AirCraftRoutNav)
            //.Select(r => new
            //{
            //    RouteId = r.Id,

            //    AirCraftModel = r.AirCraftRoutes02
            //    .Select(a => new
            //    {
            //        AircraftModel = a.AirCraftRoutNav.Model,

            //    }).ToList(),

            //    AirlineName = r.AirCraftRoutes02
            //    .Select(a=>new
            //    {
            //     AirLineName = a.AirCraftRoutNav.AirlineTable.Name
            //    }).ToList()

            //}).ToList();

            //        foreach (var r in routes)
            //        {
            //            Console.WriteLine($"Route {r.RouteId} -> Aircraft: {r.AirCraftModel}, Airline: {r.AirlineName}");
            //        }



            #endregion

            #region EFcore04 Q8

            //. For each airline, list its aircraft models. 

            var airlines = context.Set<Airline>()
            .Select(a => new
            {
                AirlineName = a.Name,
                AirCraftModels = a.AirCrafts.Select(ac => ac.Model).ToList()

            }).ToList();

            foreach (var a in airlines)
            {
                Console.WriteLine($"Airline: {a.AirlineName}");
                foreach (var model in a.AirCraftModels)
                {
                    Console.WriteLine($"   Model: {model}");
                }
            }









            #endregion

            #region EFCore04 Q9

       // Show all transactions(id, amount, description) along with the
       //airline name, but only where Amount > 20000.


        var transactions = context.Set<Transaction>()
        .Where(t => t.Amount > 20000)
        .Select(t => new
        {
             TransactionId = t.Id,
             t.Amount,
             t.Description,
             AirlineName = t.AirNav.Name

        }).ToList();

            foreach (var t in transactions)
            {
                Console.WriteLine($"Transaction {t.TransactionId}: {t.Amount} And {t.Description} (Airline: {t.AirlineName})");
            }





            #endregion

            #region EFcore04 All Question 10
           // Section C : Inheritance Mapping[New Project]
           //Q1.
           //1.Create a class Vehicle [Id, Model, Speed] 
           //2. Create a class Car [Id, Model, Speed, NumberOfDoors] 
           //3. Create a class Bus([Id , Model , Speed , Capacity ]
           //Note : Map them into a single table

            Car C01 = new Car()
            {
                Id = 1,
                Model = "Malaky",
                Speed = 290,
                NumberOfDoor = 4
            };

            context.cars.Add(C01);


            Bus B01 = new Bus()
            {
                Id = 2,
                Model = "MicroBus",
                Speed = 250,
                Capacity = 180
            };

            context.buses.Add(B01);


            //. Create a class Payment [Id, Amount] 
            //2. Create a class CreditCardPayment [Id, Amount, CardNumber] 
            //3. Create a class CashPayment [Id, Amount, Currency]
            //Note : Each Class Has its own Table

            CreditCardPayment CP01 = new CreditCardPayment()
            {
                Id = 1,
                Amount = 5,
                CardNumber = 102050
               
            };

            context.payments.Add(CP01);


            CashPayment cB01 = new CashPayment()
            {
                Id = 2,
                Amount = 6,
                Currency = "Good"
            };

            context.payments.Add (cB01);

            #endregion

        }
    }
}

using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DataContext
{
    internal class BaseContext : DbContext
    {
        public BaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCore02;Trusted_Connection=true;TrustServerCertificate = true");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.AirEmp)
            .WithMany()
            .HasForeignKey(e => e.AirEmpId);

            modelBuilder.Entity<Airline>()
                .HasMany(ac => ac.AirCrafts)
                .WithOne(al => al.AirlineTable)
                .HasForeignKey(al => al.AilineId);

            modelBuilder.Entity<Transaction>()
                .HasOne(T => T.AirNav)
                .WithMany()
                .IsRequired()
                .HasForeignKey(A => A.AirlineId);

            modelBuilder.Entity<AirCraftRoute>()
                .HasOne(acr => acr.AirCraftRoutNav)
                .WithMany(ac => ac.AirCraftNav)
                .HasForeignKey(acr => acr.AirCraftId);
            modelBuilder.Entity<AirCraftRoute>()
                .HasKey(ace => new
                {
                    ace.AirCraftId,
                    ace.RouteId
                });
            modelBuilder.Entity<AirCraftRoute>()
                .HasOne(acr => acr.RouteNav)
                .WithMany(R => R.AirCraftRoutes02)
                .HasForeignKey(R => R.RouteId);

    modelBuilder.Entity<Crew>()
                .HasKey(c => new
                {
                    c.AirCraftId,
                    c.Maj_Pilot,
                    
                });
            modelBuilder.Entity<Crew>()
                .HasOne(c => c.AirCraftNav02)
                .WithOne(ac => ac.CrewNav)
                .HasForeignKey<Crew>(ac => ac.AirCraftId)
                .IsRequired();

        }


       
    }
}

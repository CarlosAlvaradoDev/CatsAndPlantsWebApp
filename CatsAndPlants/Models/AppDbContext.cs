using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CatsAndPlants.Models
{
    public class AppDbContext : DbContext
    {
        // F i e l d s  &  P r o p e r t i e s
        public DbSet<Customer> Customers { get; set; }

        // C o n s t r u c t o r s
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // M e t h o d s
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData
               (new Customer
               {
                   CustomerId = 1,
                   FirstName = "Charlies",
                   LastName = "Avocado",
                   Email = "c@c.com",
                   Password = "Shnock123",
                   Phone = "111-111-1111",
                   ShipAddress = "123 North",
                   ShipCity = "Phoenix",
                   ShipState = "AZ",
                   ShipPostal = 52234,
                   BillAddress = "123 North",
                   BillCity = "Phoenix",
                   BillState = "AZ",
                   BillPostal = 52234,
               });

            modelBuilder.Entity<Customer>().HasData
               (new Customer
               {
                   CustomerId = 2,
                   FirstName = "Josephina",
                   LastName = "Navarro",
                   Email = "J@N.com",
                   Password = "Shnock123",
                   Phone = "222-222-2222",
                   ShipAddress = "456 South",
                   ShipCity = "Flagstaff",
                   ShipState = "AZ",
                   ShipPostal = 52233,
                   BillAddress = "123 North",
                   BillCity = "Phoenix",
                   BillState = "AZ",
                   BillPostal = 52234,
               });
        }
    }
}

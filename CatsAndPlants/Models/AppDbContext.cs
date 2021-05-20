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
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        // C o n s t r u c t o r s
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Test data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CUSTOMERS
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

            // PLANTS
            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 1,
                  Category = "Plants",
                  Name = "Mood Moss",
                  Description = "Fluffy, wave like moss.",
                  Price = 3.99F,
                  Weight = 0.2F,
                  PicUrl = "https://i.imgur.com/rpJUKWfl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 2,
                  Category = "Plants",
                  Name = "Pillow Moss",
                  Description = "Cushiony, plump moss.",
                  Price = 3.99F,
                  Weight = 0.2F,
                  PicUrl = "https://i.imgur.com/2iE4Jail.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 3,
                  Category = "Plants",
                  Name = "Pinguicula Moranesis",
                  Description = "Carnivorous plant with sticky broad leaves.",
                  Price = 9.99F,
                  Weight = 0.05F,
                  PicUrl = "https://i.imgur.com/zSdT9XOl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 4,
                  Category = "Plants",
                  Name = "Ficus Pumila",
                  Description = "Creeping vine that grows alongside walls.",
                  Price = 2.99F,
                  Weight = 0.05F,
                  PicUrl = "https://i.imgur.com/h8dbvsXl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 5,
                  Category = "Plants",
                  Name = "Peperomia Prostrata",
                  Description = "Vine like plant that resembles turtle shell like leaves.",
                  Price = 3.99F,
                  Weight = 0.1F,
                  PicUrl = "https://i.imgur.com/uwbBX0Vl.png"
              });

            // VIVARIUMS
            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 6,
                  Category = "Vivariums",
                  Name = "Small",
                  Description = "5in x 5in x 5in.",
                  Price = 24.99F,
                  Weight = 1.2F,
                  PicUrl = "https://i.imgur.com/6u4n3dNl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 7,
                  Category = "Vivariums",
                  Name = "Medium",
                  Description = "10in x 10in x 12in.",
                  Price = 39.99F,
                  Weight = 4.5F,
                  PicUrl = "https://i.imgur.com/SUCow4cl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 8,
                  Category = "Vivariums",
                  Name = "Large",
                  Description = "18in x 18in x 18in.",
                  Price = 59.99F,
                  Weight = 6.3F,
                  PicUrl = "https://i.imgur.com/P5nV16Tl.jpg"
              });

            // STANDS
            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 9,
                  Category = "Stands",
                  Name = "Small",
                  Description = "For small vivariums. Includes base and grow light",
                  Price = 10.99F,
                  Weight = 1.2F,
                  PicUrl = "https://i.imgur.com/BxM2HW0l.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 10,
                  Category = "Stands",
                  Name = "Medium",
                  Description = "For medium vivariums. Includes base and grow light",
                  Price = 15.99F,
                  Weight = 2.0F,
                  PicUrl = "https://i.imgur.com/uW6K5dil.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 11,
                  Category = "Stands",
                  Name = "Large",
                  Description = "For large vivariums. Includes base and grow light",
                  Price = 20.99F,
                  Weight = 3.4F,
                  PicUrl = "https://i.imgur.com/vKANYKJl.jpg"
              });

            // SUPPLIES
            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 12,
                  Category = "Supplies",
                  Name = "Soil Mix",
                  Description = "Special soil mix made to withstand high humdity that won't break down quickly.",
                  Price = 9.99F,
                  Weight = 1.5F,
                  PicUrl = "https://i.imgur.com/4wQIspul.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 13,
                  Category = "Supplies",
                  Name = "Spray Bottle",
                  Description = "A continuous mister that sprays a fine mist.",
                  Price = 3.99F,
                  Weight = 0.3F,
                  PicUrl = "https://i.imgur.com/1NYHFSPl.jpg"
              });

            modelBuilder.Entity<Product>().HasData
              (new Product
              {
                  ProductId = 14,
                  Category = "Supplies",
                  Name = "Fertilizer",
                  Description = "Mild fertilizer that will boost plant growth. Mix in spray bottle",
                  Price = 3.99F,
                  Weight = 0.3F,
                  PicUrl = "https://i.imgur.com/tj3wfznl.jpg"
              });
        }
        
    }
}

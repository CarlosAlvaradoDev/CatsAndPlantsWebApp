﻿// <auto-generated />
using System;
using CatsAndPlants.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatsAndPlants.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210516185410_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CatsAndPlants.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BillPostal")
                        .HasColumnType("int");

                    b.Property<string>("BillState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipPostal")
                        .HasColumnType("int");

                    b.Property<string>("ShipState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            BillAddress = "123 North",
                            BillCity = "Phoenix",
                            BillPostal = 52234,
                            BillState = "AZ",
                            Email = "c@c.com",
                            FirstName = "Charlies",
                            LastName = "Avocado",
                            Password = "Shnock123",
                            Phone = "111-111-1111",
                            ShipAddress = "123 North",
                            ShipCity = "Phoenix",
                            ShipPostal = 52234,
                            ShipState = "AZ"
                        },
                        new
                        {
                            CustomerId = 2,
                            BillAddress = "123 North",
                            BillCity = "Phoenix",
                            BillPostal = 52234,
                            BillState = "AZ",
                            Email = "J@N.com",
                            FirstName = "Josephina",
                            LastName = "Navarro",
                            Password = "Shnock123",
                            Phone = "222-222-2222",
                            ShipAddress = "456 South",
                            ShipCity = "Flagstaff",
                            ShipPostal = 52233,
                            ShipState = "AZ"
                        });
                });

            modelBuilder.Entity("CatsAndPlants.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Freight")
                        .HasColumnType("real");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalCost")
                        .HasColumnType("real");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CatsAndPlants.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Plants",
                            Description = "Fluffy moss.",
                            Name = "Mood Moss",
                            Price = 3.99f,
                            Weight = 0.2f
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Plants",
                            Description = "Cushiony, plump moss.",
                            Name = "Pillow Moss",
                            Price = 3.99f,
                            Weight = 0.2f
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Plants",
                            Description = "Carnivorous plant with sticky broad leaves.",
                            Name = "Pinguicula Moranesis",
                            Price = 9.99f,
                            Weight = 0.05f
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Plants",
                            Description = "Creeping vine that grows alongside walls.",
                            Name = "Ficus Pumila",
                            Price = 2.99f,
                            Weight = 0.05f
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Plants",
                            Description = "Vine like plant that resembles turtle shell like leaves.",
                            Name = "Peperomia Prostrata",
                            Price = 3.99f,
                            Weight = 0.1f
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Vivariums",
                            Description = "5in x 5in x 5in.",
                            Name = "Small",
                            Price = 24.99f,
                            Weight = 1.2f
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Vivariums",
                            Description = "10in x 10in x 12in.",
                            Name = "Medium",
                            Price = 39.99f,
                            Weight = 4.5f
                        },
                        new
                        {
                            ProductId = 8,
                            Category = "Vivariums",
                            Description = "18in x 18in x 18in.",
                            Name = "Large",
                            Price = 59.99f,
                            Weight = 6.3f
                        },
                        new
                        {
                            ProductId = 9,
                            Category = "Stands",
                            Description = "For small vivariums.",
                            Name = "Small",
                            Price = 10.99f,
                            Weight = 1.2f
                        },
                        new
                        {
                            ProductId = 10,
                            Category = "Stands",
                            Description = "For medium vivariums.",
                            Name = "Medium",
                            Price = 15.99f,
                            Weight = 2f
                        },
                        new
                        {
                            ProductId = 11,
                            Category = "Stands",
                            Description = "For large vivariums.",
                            Name = "Large",
                            Price = 20.99f,
                            Weight = 3.4f
                        },
                        new
                        {
                            ProductId = 12,
                            Category = "Supplies",
                            Description = "Special soil mix made to withstand high humdity that won't break down quickly.",
                            Name = "Soil Mix",
                            Price = 9.99f,
                            Weight = 1.5f
                        },
                        new
                        {
                            ProductId = 13,
                            Category = "Supplies",
                            Description = "A continuous mister that sprays a fine mist.",
                            Name = "Spray Bottle",
                            Price = 3.99f,
                            Weight = 0.3f
                        },
                        new
                        {
                            ProductId = 14,
                            Category = "Supplies",
                            Description = "Mild fertilizer that will boost plant growth. Mix in spray bottle",
                            Name = "Fertilizer",
                            Price = 3.99f,
                            Weight = 0.3f
                        });
                });

            modelBuilder.Entity("CatsAndPlants.Models.Order", b =>
                {
                    b.HasOne("CatsAndPlants.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CatsAndPlants.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
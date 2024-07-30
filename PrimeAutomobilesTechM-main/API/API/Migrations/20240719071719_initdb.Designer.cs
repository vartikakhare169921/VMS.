﻿// <auto-generated />
using System;
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240719071719_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ordered")
                        .HasColumnType("bit");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CarCategoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarCategoryId = 1,
                            Name = "Introduction to Algorithm",
                            Ordered = false,
                            Owner = "Thomas Corman",
                            Price = 100f
                        },
                        new
                        {
                            Id = 2,
                            CarCategoryId = 1,
                            Name = "Introduction to Algorithm",
                            Ordered = false,
                            Owner = "Thomas Corman",
                            Price = 100f
                        },
                        new
                        {
                            Id = 3,
                            CarCategoryId = 1,
                            Name = "Algorithms",
                            Ordered = false,
                            Owner = "Robert Sedgewick & Kevin Wayne",
                            Price = 200f
                        },
                        new
                        {
                            Id = 4,
                            CarCategoryId = 1,
                            Name = "The Algorithm Design Manual",
                            Ordered = false,
                            Owner = "Steve Skiena",
                            Price = 300f
                        },
                        new
                        {
                            Id = 5,
                            CarCategoryId = 1,
                            Name = "Algorithms For Interviews",
                            Ordered = false,
                            Owner = "Adnan Aziz",
                            Price = 400f
                        },
                        new
                        {
                            Id = 6,
                            CarCategoryId = 1,
                            Name = "Algorithms For Interviews",
                            Ordered = false,
                            Owner = "Adnan Aziz",
                            Price = 400f
                        },
                        new
                        {
                            Id = 7,
                            CarCategoryId = 1,
                            Name = "Algorithms For Interviews",
                            Ordered = false,
                            Owner = "Adnan Aziz",
                            Price = 400f
                        },
                        new
                        {
                            Id = 8,
                            CarCategoryId = 1,
                            Name = "Algorithm in Nutshell",
                            Ordered = false,
                            Owner = "George Heineman",
                            Price = 500f
                        },
                        new
                        {
                            Id = 9,
                            CarCategoryId = 1,
                            Name = "Klienberg & Tardos",
                            Ordered = false,
                            Owner = "Algorithm Design",
                            Price = 600f
                        },
                        new
                        {
                            Id = 10,
                            CarCategoryId = 2,
                            Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Ordered = false,
                            Owner = "Eric Matthes",
                            Price = 700f
                        },
                        new
                        {
                            Id = 11,
                            CarCategoryId = 2,
                            Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Ordered = false,
                            Owner = "Eric Matthes",
                            Price = 700f
                        },
                        new
                        {
                            Id = 12,
                            CarCategoryId = 2,
                            Name = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Ordered = false,
                            Owner = "Eric Matthes",
                            Price = 700f
                        },
                        new
                        {
                            Id = 13,
                            CarCategoryId = 2,
                            Name = "Head First Python: A Brain-Friendly Guide",
                            Ordered = false,
                            Owner = "Paul Barry",
                            Price = 800f
                        },
                        new
                        {
                            Id = 14,
                            CarCategoryId = 2,
                            Name = "Effective Java",
                            Ordered = false,
                            Owner = "Joshua Bloch",
                            Price = 900f
                        },
                        new
                        {
                            Id = 15,
                            CarCategoryId = 2,
                            Name = "Effective Java",
                            Ordered = false,
                            Owner = "Joshua Bloch",
                            Price = 900f
                        },
                        new
                        {
                            Id = 16,
                            CarCategoryId = 2,
                            Name = "Head First Java",
                            Ordered = false,
                            Owner = "Kathy Sierra and Bert Bates",
                            Price = 1000f
                        },
                        new
                        {
                            Id = 17,
                            CarCategoryId = 2,
                            Name = "C Programming Language",
                            Ordered = false,
                            Owner = "Brian W. Kernighan, Dennis M. Ritchie",
                            Price = 1100f
                        },
                        new
                        {
                            Id = 18,
                            CarCategoryId = 2,
                            Name = "C Programming Language",
                            Ordered = false,
                            Owner = "Brian W. Kernighan, Dennis M. Ritchie",
                            Price = 1100f
                        },
                        new
                        {
                            Id = 19,
                            CarCategoryId = 2,
                            Name = "C Programming Language",
                            Ordered = false,
                            Owner = "Brian W. Kernighan, Dennis M. Ritchie",
                            Price = 1100f
                        },
                        new
                        {
                            Id = 20,
                            CarCategoryId = 2,
                            Name = "Eloquent JavaScript: A Modern Introduction to Programming",
                            Ordered = false,
                            Owner = "Marijn Haverbeke",
                            Price = 1200f
                        },
                        new
                        {
                            Id = 21,
                            CarCategoryId = 2,
                            Name = "The Art of Computer Programming",
                            Ordered = false,
                            Owner = "Donald E. Knuth",
                            Price = 1300f
                        },
                        new
                        {
                            Id = 22,
                            CarCategoryId = 2,
                            Name = "The Art of Computer Programming",
                            Ordered = false,
                            Owner = "Donald E. Knuth",
                            Price = 1300f
                        },
                        new
                        {
                            Id = 23,
                            CarCategoryId = 3,
                            Name = "A Top-Down Approach: Computer Networking",
                            Ordered = false,
                            Owner = "James F Kurose and Keith W Ross",
                            Price = 1400f
                        },
                        new
                        {
                            Id = 24,
                            CarCategoryId = 3,
                            Name = "The All-New Switch Book (2nd Edition)",
                            Ordered = false,
                            Owner = "Rich Seifert and James Edwards",
                            Price = 1500f
                        },
                        new
                        {
                            Id = 25,
                            CarCategoryId = 3,
                            Name = "The All-New Switch Book (2nd Edition)",
                            Ordered = false,
                            Owner = "Rich Seifert and James Edwards",
                            Price = 1500f
                        },
                        new
                        {
                            Id = 26,
                            CarCategoryId = 3,
                            Name = "Business Data Communications and Networking (14th Edition)",
                            Ordered = false,
                            Owner = "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova",
                            Price = 1600f
                        },
                        new
                        {
                            Id = 27,
                            CarCategoryId = 3,
                            Name = "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition",
                            Ordered = false,
                            Owner = "Forouzan",
                            Price = 1700f
                        },
                        new
                        {
                            Id = 28,
                            CarCategoryId = 3,
                            Name = "Network Warrior, 2nd Edition",
                            Ordered = false,
                            Owner = "Gary Donahue",
                            Price = 1800f
                        },
                        new
                        {
                            Id = 29,
                            CarCategoryId = 3,
                            Name = "Network Warrior, 2nd Edition",
                            Ordered = false,
                            Owner = "Gary Donahue",
                            Price = 1800f
                        },
                        new
                        {
                            Id = 30,
                            CarCategoryId = 3,
                            Name = "Network Warrior, 2nd Edition",
                            Ordered = false,
                            Owner = "Gary Donahue",
                            Price = 1800f
                        },
                        new
                        {
                            Id = 31,
                            CarCategoryId = 4,
                            Name = "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)",
                            Ordered = false,
                            Owner = "Ramesh Gaonkar",
                            Price = 1900f
                        },
                        new
                        {
                            Id = 32,
                            CarCategoryId = 4,
                            Name = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)",
                            Ordered = false,
                            Owner = "Douglas V. Hall",
                            Price = 2000f
                        },
                        new
                        {
                            Id = 33,
                            CarCategoryId = 4,
                            Name = "Microprocessors and Interfacing: Programming and Hardware (Hardcover)",
                            Ordered = false,
                            Owner = "Douglas V. Hall",
                            Price = 2000f
                        },
                        new
                        {
                            Id = 34,
                            CarCategoryId = 4,
                            Name = "Embedded Microprocessor Systems Design",
                            Ordered = false,
                            Owner = "Kenneth L. Short",
                            Price = 2100f
                        },
                        new
                        {
                            Id = 35,
                            CarCategoryId = 4,
                            Name = "Digital Electronics & Microprocessor",
                            Ordered = false,
                            Owner = "Dr. Vibhav Kumar Sachan",
                            Price = 2200f
                        },
                        new
                        {
                            Id = 36,
                            CarCategoryId = 4,
                            Name = "Real-Time Embedded Systems",
                            Ordered = false,
                            Owner = "Xiaocong Fan",
                            Price = 2300f
                        },
                        new
                        {
                            Id = 37,
                            CarCategoryId = 4,
                            Name = "Digital Interface Design and Application",
                            Ordered = false,
                            Owner = "Jonathan A. Dell",
                            Price = 2400f
                        },
                        new
                        {
                            Id = 38,
                            CarCategoryId = 5,
                            Name = "Richard G. Budynas and Keith J. Nisbett",
                            Ordered = false,
                            Owner = "Shigley's Mechanical Engineering Design",
                            Price = 2500f
                        },
                        new
                        {
                            Id = 39,
                            CarCategoryId = 5,
                            Name = "Richard G. Budynas and Keith J. Nisbett",
                            Ordered = false,
                            Owner = "Shigley's Mechanical Engineering Design",
                            Price = 2500f
                        },
                        new
                        {
                            Id = 40,
                            CarCategoryId = 5,
                            Name = "Richard G. Budynas and Keith J. Nisbett",
                            Ordered = false,
                            Owner = "Shigley's Mechanical Engineering Design",
                            Price = 2500f
                        },
                        new
                        {
                            Id = 41,
                            CarCategoryId = 5,
                            Name = "Machinery's Handbook",
                            Ordered = false,
                            Owner = "Erik Oberg",
                            Price = 2600f
                        },
                        new
                        {
                            Id = 42,
                            CarCategoryId = 5,
                            Name = "Introduction to Robotics: Mechanics and Control",
                            Ordered = false,
                            Owner = "John J. Craig",
                            Price = 2700f
                        },
                        new
                        {
                            Id = 43,
                            CarCategoryId = 5,
                            Name = "Machine Design",
                            Ordered = false,
                            Owner = "Robert L. Norton",
                            Price = 2800f
                        },
                        new
                        {
                            Id = 44,
                            CarCategoryId = 5,
                            Name = "Machine Design",
                            Ordered = false,
                            Owner = "Robert L. Norton",
                            Price = 2800f
                        },
                        new
                        {
                            Id = 45,
                            CarCategoryId = 6,
                            Name = "Fluid Mechanics",
                            Ordered = false,
                            Owner = "Frank M. White",
                            Price = 3000f
                        },
                        new
                        {
                            Id = 46,
                            CarCategoryId = 6,
                            Name = "Fundamentals of Thermodynamics",
                            Ordered = false,
                            Owner = "Claus Borgnakke and Richard E. Sonntag",
                            Price = 3100f
                        },
                        new
                        {
                            Id = 47,
                            CarCategoryId = 6,
                            Name = "Fundamentals of Thermodynamics",
                            Ordered = false,
                            Owner = "Claus Borgnakke and Richard E. Sonntag",
                            Price = 3100f
                        },
                        new
                        {
                            Id = 48,
                            CarCategoryId = 7,
                            Name = "Calculus: Early Transcendentals",
                            Ordered = false,
                            Owner = "James Stewart",
                            Price = 3200f
                        },
                        new
                        {
                            Id = 49,
                            CarCategoryId = 7,
                            Name = "Calculus for Dummies",
                            Ordered = false,
                            Owner = "Mark Ryan",
                            Price = 3300f
                        },
                        new
                        {
                            Id = 50,
                            CarCategoryId = 7,
                            Name = "Calculus for Dummies",
                            Ordered = false,
                            Owner = "Mark Ryan",
                            Price = 3300f
                        },
                        new
                        {
                            Id = 51,
                            CarCategoryId = 7,
                            Name = "The Calculus with Analytic Geometry",
                            Ordered = false,
                            Owner = "Louis Leithold",
                            Price = 3400f
                        },
                        new
                        {
                            Id = 52,
                            CarCategoryId = 8,
                            Name = "Euclid's Elements",
                            Ordered = false,
                            Owner = "Euclid",
                            Price = 3500f
                        },
                        new
                        {
                            Id = 53,
                            CarCategoryId = 8,
                            Name = "The Man Who Knew Infinity: A Life of the Genius Ramanujan",
                            Ordered = false,
                            Owner = "Robert Kanigel",
                            Price = 3600f
                        },
                        new
                        {
                            Id = 54,
                            CarCategoryId = 8,
                            Name = "The Man Who Knew Infinity: A Life of the Genius Ramanujan",
                            Ordered = false,
                            Owner = "Robert Kanigel",
                            Price = 3600f
                        },
                        new
                        {
                            Id = 55,
                            CarCategoryId = 8,
                            Name = "A Brief History of Time",
                            Ordered = false,
                            Owner = "Stephen Hawking",
                            Price = 3700f
                        },
                        new
                        {
                            Id = 56,
                            CarCategoryId = 8,
                            Name = "Relativity: The Special and the General Theory",
                            Ordered = false,
                            Owner = "Albert Einstein",
                            Price = 3800f
                        },
                        new
                        {
                            Id = 57,
                            CarCategoryId = 8,
                            Name = "Relativity: The Special and the General Theory",
                            Ordered = false,
                            Owner = "Albert Einstein",
                            Price = 3800f
                        },
                        new
                        {
                            Id = 58,
                            CarCategoryId = 8,
                            Name = "Relativity: The Special and the General Theory",
                            Ordered = false,
                            Owner = "Albert Einstein",
                            Price = 3800f
                        },
                        new
                        {
                            Id = 59,
                            CarCategoryId = 8,
                            Name = "Relativity: The Special and the General Theory",
                            Ordered = false,
                            Owner = "Albert Einstein",
                            Price = 3800f
                        },
                        new
                        {
                            Id = 60,
                            CarCategoryId = 8,
                            Name = "Relativity: The Special and the General Theory",
                            Ordered = false,
                            Owner = "Albert Einstein",
                            Price = 3800f
                        });
                });

            modelBuilder.Entity("API.Entities.CarCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "computer",
                            SubCategory = "algorithm"
                        },
                        new
                        {
                            Id = 2,
                            Category = "computer",
                            SubCategory = "programming languages"
                        },
                        new
                        {
                            Id = 3,
                            Category = "computer",
                            SubCategory = "networking"
                        },
                        new
                        {
                            Id = 4,
                            Category = "computer",
                            SubCategory = "hardware"
                        },
                        new
                        {
                            Id = 5,
                            Category = "mechanical",
                            SubCategory = "machine"
                        },
                        new
                        {
                            Id = 6,
                            Category = "mechanical",
                            SubCategory = "transfer of energy"
                        },
                        new
                        {
                            Id = 7,
                            Category = "mathematics",
                            SubCategory = "calculus"
                        },
                        new
                        {
                            Id = 8,
                            Category = "mathematics",
                            SubCategory = "algebra"
                        });
                });

            modelBuilder.Entity("API.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            LastName = "",
                            MobileNumber = "1234567890",
                            Password = "admin1999",
                            UserType = "ADMIN"
                        });
                });

            modelBuilder.Entity("API.Entities.Car", b =>
                {
                    b.HasOne("API.Entities.CarCategory", "CarCategory")
                        .WithMany()
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarCategory");
                });

            modelBuilder.Entity("API.Entities.Order", b =>
                {
                    b.HasOne("API.Entities.Car", "Book")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

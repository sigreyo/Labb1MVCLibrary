// <auto-generated />
using System;
using Labb1MVC_Simon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb1MVC_Simon.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20220922073303_users")]
    partial class users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb1MVC_Simon.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<int?>("PageCount")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Amount = 5,
                            LoanId = 12
                        },
                        new
                        {
                            BookId = 2,
                            Amount = 3,
                            LoanId = 5
                        },
                        new
                        {
                            BookId = 3,
                            Amount = 3,
                            LoanId = 6
                        },
                        new
                        {
                            BookId = 4,
                            Amount = 5,
                            LoanId = 12
                        },
                        new
                        {
                            BookId = 5,
                            Amount = 1,
                            LoanId = 10
                        },
                        new
                        {
                            BookId = 6,
                            Amount = 2,
                            LoanId = 17
                        },
                        new
                        {
                            BookId = 7,
                            Amount = 3,
                            LoanId = 2
                        },
                        new
                        {
                            BookId = 8,
                            Amount = 4,
                            LoanId = 1
                        },
                        new
                        {
                            BookId = 9,
                            Amount = 5,
                            LoanId = 15
                        },
                        new
                        {
                            BookId = 10,
                            Amount = 3,
                            LoanId = 4
                        },
                        new
                        {
                            BookId = 11,
                            Amount = 4,
                            LoanId = 11
                        },
                        new
                        {
                            BookId = 12,
                            Amount = 3,
                            LoanId = 6
                        },
                        new
                        {
                            BookId = 13,
                            Amount = 4,
                            LoanId = 12
                        },
                        new
                        {
                            BookId = 14,
                            Amount = 1,
                            LoanId = 8
                        },
                        new
                        {
                            BookId = 15,
                            Amount = 1,
                            LoanId = 18
                        },
                        new
                        {
                            BookId = 16,
                            Amount = 1,
                            LoanId = 6
                        },
                        new
                        {
                            BookId = 17,
                            Amount = 1,
                            LoanId = 15
                        },
                        new
                        {
                            BookId = 18,
                            Amount = 2,
                            LoanId = 7
                        },
                        new
                        {
                            BookId = 19,
                            Amount = 5,
                            LoanId = 14
                        },
                        new
                        {
                            BookId = 20,
                            Amount = 2,
                            LoanId = 1
                        });
                });

            modelBuilder.Entity("Labb1MVC_Simon.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Reid Hollow 555",
                            FullName = "Chester Miller",
                            LoanId = 29,
                            Phone = "563-777-7149"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Aiyana Fork 2033",
                            FullName = "Jamey Maggio",
                            LoanId = 21,
                            Phone = "447-227-8455"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Schowalter Highway 1456",
                            FullName = "Magdalen Hills",
                            LoanId = 38,
                            Phone = "867-557-7339"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "Bosco Light 392",
                            FullName = "Anthony Carter",
                            LoanId = 39,
                            Phone = "728-758-0874"
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "Tomasa Glen 2348",
                            FullName = "Litzy Gibson",
                            LoanId = 14,
                            Phone = "783-628-3738"
                        },
                        new
                        {
                            CustomerId = 6,
                            Address = "Kerluke Green 991",
                            FullName = "Keaton Homenick",
                            LoanId = 34,
                            Phone = "231-352-6093"
                        },
                        new
                        {
                            CustomerId = 7,
                            Address = "Jerde Fort 558",
                            FullName = "Alfreda Prohaska",
                            LoanId = 2,
                            Phone = "939-328-9138"
                        },
                        new
                        {
                            CustomerId = 8,
                            Address = "Crooks Plaza 1564",
                            FullName = "Jan Swaniawski",
                            LoanId = 23,
                            Phone = "536-265-4586"
                        },
                        new
                        {
                            CustomerId = 9,
                            Address = "Becker Road 1582",
                            FullName = "Dustin Cormier",
                            LoanId = 11,
                            Phone = "730-688-1387"
                        },
                        new
                        {
                            CustomerId = 10,
                            Address = "Harvey Throughway 325",
                            FullName = "Tony Runolfsdottir",
                            LoanId = 20,
                            Phone = "319-369-5237"
                        },
                        new
                        {
                            CustomerId = 11,
                            Address = "Jerrold Plaza 1654",
                            FullName = "Arjun Metz",
                            LoanId = 34,
                            Phone = "983-963-7238"
                        },
                        new
                        {
                            CustomerId = 12,
                            Address = "Vito Parkway 746",
                            FullName = "Burnice Windler",
                            LoanId = 13,
                            Phone = "819-896-0751"
                        },
                        new
                        {
                            CustomerId = 13,
                            Address = "Reinger Mall 1152",
                            FullName = "Beau Hilpert",
                            LoanId = 20,
                            Phone = "380-728-4466"
                        },
                        new
                        {
                            CustomerId = 14,
                            Address = "Trantow Skyway 636",
                            FullName = "Tressa Jenkins",
                            LoanId = 32,
                            Phone = "782-995-2006"
                        },
                        new
                        {
                            CustomerId = 15,
                            Address = "Alexander Road 43",
                            FullName = "Loraine Towne",
                            LoanId = 13,
                            Phone = "786-329-0335"
                        },
                        new
                        {
                            CustomerId = 16,
                            Address = "Rolando Gardens 29",
                            FullName = "Alfonzo Ankunding",
                            LoanId = 28,
                            Phone = "388-480-4923"
                        },
                        new
                        {
                            CustomerId = 17,
                            Address = "Collins Oval 236",
                            FullName = "Ceasar Weimann",
                            LoanId = 5,
                            Phone = "884-236-8848"
                        },
                        new
                        {
                            CustomerId = 18,
                            Address = "Jaida Forest 598",
                            FullName = "Freda Jakubowski",
                            LoanId = 25,
                            Phone = "812-680-0816"
                        },
                        new
                        {
                            CustomerId = 19,
                            Address = "Georgiana Drive 941",
                            FullName = "Brad Murazik",
                            LoanId = 10,
                            Phone = "585-277-3941"
                        },
                        new
                        {
                            CustomerId = 20,
                            Address = "Schmitt Manor 2088",
                            FullName = "Merritt Kutch",
                            LoanId = 6,
                            Phone = "910-706-0759"
                        });
                });

            modelBuilder.Entity("Labb1MVC_Simon.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookLoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BookReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DaysToLoan")
                        .HasColumnType("int");

                    b.Property<bool?>("ReturnedInTime")
                        .HasColumnType("bit");

                    b.HasKey("LoanId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            LoanId = 1,
                            BookId = 14,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7464),
                            CustomerId = 9,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 2,
                            BookId = 20,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7845),
                            CustomerId = 7,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 3,
                            BookId = 17,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7858),
                            CustomerId = 17,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 4,
                            BookId = 17,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7864),
                            CustomerId = 3,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 5,
                            BookId = 8,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7870),
                            CustomerId = 11,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 6,
                            BookId = 14,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7876),
                            CustomerId = 8,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 7,
                            BookId = 2,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7882),
                            CustomerId = 19,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 8,
                            BookId = 12,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7887),
                            CustomerId = 15,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 9,
                            BookId = 20,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7892),
                            CustomerId = 4,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 10,
                            BookId = 4,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7898),
                            CustomerId = 19,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 11,
                            BookId = 17,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7903),
                            CustomerId = 20,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 12,
                            BookId = 10,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7908),
                            CustomerId = 14,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 13,
                            BookId = 8,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7914),
                            CustomerId = 5,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 14,
                            BookId = 19,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7919),
                            CustomerId = 16,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 15,
                            BookId = 10,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7925),
                            CustomerId = 16,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 16,
                            BookId = 20,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7930),
                            CustomerId = 12,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 17,
                            BookId = 4,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7935),
                            CustomerId = 10,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 18,
                            BookId = 5,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7941),
                            CustomerId = 14,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 19,
                            BookId = 18,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7946),
                            CustomerId = 7,
                            DaysToLoan = 30
                        },
                        new
                        {
                            LoanId = 20,
                            BookId = 2,
                            BookLoanDate = new DateTime(2022, 9, 22, 9, 33, 3, 238, DateTimeKind.Local).AddTicks(7951),
                            CustomerId = 17,
                            DaysToLoan = 30
                        });
                });

            modelBuilder.Entity("Labb1MVC_Simon.Models.Loan", b =>
                {
                    b.HasOne("Labb1MVC_Simon.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1MVC_Simon.Models.Customer", "Customer")
                        .WithMany("Loans")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Labb1MVC_Simon.Models.Book", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Labb1MVC_Simon.Models.Customer", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}

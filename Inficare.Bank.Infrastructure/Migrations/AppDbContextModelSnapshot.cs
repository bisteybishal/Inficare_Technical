﻿// <auto-generated />
using Inficare.Bank.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inficare.Bank.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inficare.Bank.Domain.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "kirtipur",
                            Name = "NIC Asia"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Lalitput",
                            Name = "NABIL"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Chitwan",
                            Name = "Himalayan"
                        });
                });

            modelBuilder.Entity("Inficare.Bank.Domain.Models.BankEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankEmployees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            Password = "Bista12@"
                        });
                });

            modelBuilder.Entity("Inficare.Bank.Domain.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankId = 1,
                            Name = "Bishal Bista",
                            PanNumber = "1234"
                        },
                        new
                        {
                            Id = 2,
                            BankId = 1,
                            Name = "Aakash Bista",
                            PanNumber = "1734"
                        },
                        new
                        {
                            Id = 3,
                            BankId = 2,
                            Name = "Shyam Bista",
                            PanNumber = "1254"
                        },
                        new
                        {
                            Id = 4,
                            BankId = 3,
                            Name = "Bijay Bhattrai",
                            PanNumber = "1204"
                        });
                });

            modelBuilder.Entity("Inficare.Bank.Domain.Models.Customer", b =>
                {
                    b.HasOne("Inficare.Bank.Domain.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });
#pragma warning restore 612, 618
        }
    }
}

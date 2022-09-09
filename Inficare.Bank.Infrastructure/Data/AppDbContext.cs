using Inficare.Bank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Inficare.Bank.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankEmployee>().HasData(
                new BankEmployee
                {
                    Id=1,
                    Email="admin@admin.com",
                    Password="Bista12@" // this is just for test purpose, in real world you would hash password before saving it to DB
                }
            );

            modelBuilder.Entity<Domain.Models.Bank>().HasData(
                new Domain.Models.Bank { Id = 1, Name = "NIC Asia", Address = "kirtipur" },
                new Domain.Models.Bank { Id = 2, Name = "NABIL", Address = "Lalitput" },
                new Domain.Models.Bank { Id = 3, Name = "Himalayan", Address = "Chitwan" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Bishal Bista", PanNumber = "1234", BankId=1},
                new Customer { Id = 2, Name = "Aakash Bista", PanNumber = "1734", BankId = 1},
                new Customer { Id = 3, Name = "Shyam Bista", PanNumber = "1254", BankId = 2 },
                new Customer { Id = 4, Name = "Bijay Bhattrai", PanNumber = "1204", BankId = 3 }
            );
        }
        public virtual DbSet<Domain.Models.Bank> Banks { get; set; }
        public virtual DbSet<BankEmployee> BankEmployees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}

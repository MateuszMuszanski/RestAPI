using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Entities
{
    public class PizzaDbContext : DbContext
    {
        private string _connectionString =
            "Server=LAPTOP-DK3CAH1M\\SQLEXPRESS;Database=PizzaAPI;Trusted_Connection=True;";
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().Property(p => p.NazwaPizzy).IsRequired();
            modelBuilder.Entity<Pizza>().Property(p => p.Skladniki).IsRequired();
            modelBuilder.Entity<Pizza>().Property(p => p.CenaPizzy).IsRequired();

            modelBuilder.Entity<Delivery>().Property(d => d.Miejscowosc).IsRequired();
            modelBuilder.Entity<Delivery>().Property(d => d.NumerDomu).IsRequired();

            modelBuilder.Entity<Order>().Property(o => o.CenaZamowienia).IsRequired();
            modelBuilder.Entity<Order>().Property(o => o.NumerTelefonu).IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

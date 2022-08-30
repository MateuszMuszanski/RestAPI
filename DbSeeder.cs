using PizzaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI
{
    public class DbSeeder
    {
        private readonly PizzaDbContext dbContext;

        public DbSeeder(PizzaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Seed()
        {
            if (dbContext.Database.CanConnect())
            {
                if (!dbContext.Orders.Any())
                {
                    var orders = GetOrders();
                    dbContext.Orders.AddRange(orders);
                    dbContext.SaveChanges();
                }
            }
            if (dbContext.Database.CanConnect())
            {
                if (!dbContext.Deliveries.Any())
                {
                    var deliveries = GetDeliveries();
                    dbContext.Deliveries.AddRange(deliveries);
                    dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>()
            {
                new Order
                {
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza()
                        {
                            NazwaPizzy = "Pizza z Salami",
                            Skladniki = "Salami, Ser, Oliwki",
                            CenaPizzy = 26.15
                        },
                        new Pizza()
                        {
                            NazwaPizzy = "Pizza z Szynką",
                            Skladniki = "Szynka, Ser, Papryka",
                            CenaPizzy = 25.30
                        }
                    },
                    NumerTelefonu = "736656288",
                    CenaZamowienia = 50,
                    Opis = "Dostawa na 19:00"
                },
                new Order()
                {
                    Pizzas = new List<Pizza>()
                    {
                        new Pizza()
                        {
                            NazwaPizzy = "Pizza z Salami",
                            Skladniki = "Salami, Ser, Oliwki",
                            CenaPizzy = 26.15
                        },
                        new Pizza()
                        {
                            NazwaPizzy = "Pizza z Szynką",
                            Skladniki = "Szynka, Ser, Papryka",
                            CenaPizzy = 25.30
                        }
                    },
                    NumerTelefonu = "736656288",
                    CenaZamowienia = 50,
                }

            };
            return orders;
        }
        private IEnumerable<Delivery> GetDeliveries()
        {
            var deliveries = new List<Delivery>()
            {
                new Delivery
                {
                    Miejscowosc = "Golcowa",
                    NumerDomu = "403A",
                    OrderId = 1
                }
            };
            return deliveries;
        }
    }
}

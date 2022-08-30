using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        //public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public string NumerTelefonu { get; set; }
        public double CenaZamowienia { get; set; }
        public string Opis { get; set; }
    }
}

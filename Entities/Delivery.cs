using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Entities
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string Miejscowosc { get; set; }
        public string NumerDomu { get; set; }
        public string Opis { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}

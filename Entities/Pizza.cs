using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Entities
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string NazwaPizzy { get; set; }
        public string Skladniki { get; set; }
        public double CenaPizzy { get; set; }
        public string Opis { get; set; }
        public Order Order { get; set; }
    }
}

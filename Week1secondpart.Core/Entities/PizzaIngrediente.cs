using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1secondpart.Core.Entities
{
    public class PizzaIngrediente
    {
        public Pizza Pizza { get; set; }
        public int IdPizza { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public int IdIngr { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1secondpart.Core.Entities
{
    public class PizzaIngrediente
    {
        public int IdPizza { get; set; }
        public int IdIngr { get; set; }

        public PizzaIngrediente(int idPizza, int idIngrediente)
        {
            IdPizza = idPizza;
            IdIngr = idIngrediente;
        }

        public PizzaIngrediente() { }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Mock
{
    public class RepositoryPizzeIngredientiMock : IPizzaIngrediente
    {
        public static List<PizzaIngrediente> pizzeIngredienti = new List<PizzaIngrediente>()
        {
            //Marinara
            new PizzaIngrediente(1,1),
            new PizzaIngrediente(1,4),
            new PizzaIngrediente(1,7),
            //MArgherita
            new PizzaIngrediente(2,1),
            new PizzaIngrediente(2,2),
            new PizzaIngrediente(2,3),
            //Vegetariana
            new PizzaIngrediente(3,1),
            new PizzaIngrediente(3,5),
            new PizzaIngrediente(3,6),
        };

        public List<PizzaIngrediente> GetAll()
        {
            return pizzeIngredienti;
        }
    }
}

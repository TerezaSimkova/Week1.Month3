using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Mock
{
    public class RepositoryPizzaMock : IRepositoryPizza
    {
        public static List<Pizza> pizze = new List<Pizza>()
        {
            new Pizza{Nome = "Marinara", Ingredienti = new List<string>(new string[] { "pomodoro", "acciughe", "mozzarella", "friarieli" }), Prezzo = 8},
            new Pizza{Nome = "Margherita", Ingredienti = new List<string>(new string[] { "pomodoro", "mozzarella", "basilico" }), Prezzo = 6},
            new Pizza{Nome = "Vegetariana", Ingredienti = new List<string>(new string[] { "pomodoro", "verdure_grigliate", "basilico" }), Prezzo = 7},
        };

        public List<Pizza> conto = new List<Pizza>() { };

        public Pizza Add(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void AddToConto(Pizza existPizza)
        {
            conto.Add(existPizza);
        }

        public bool Delete(Pizza item)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
        {
            return pizze;
        }

        public Pizza GetByName(string nome)
        {
            //var pizza = pizze.FirstOrDefault(p => p.Nome == nome);
            //return pizza;

            var pizza = from item in pizze
                          where item.Nome == nome
                          select item;

            return pizza.Single();
        }

        public Pizza Update(Pizza item)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Mock
{
    public class RepositoryPizzaMock : IRepositoryPizza
    {
        public static List<Pizza> pizze = new List<Pizza>()
        {
            new Pizza{Id = 1,Nome = "Marinara", Prezzo = 8},
            new Pizza{Id = 2,Nome = "Margherita",Prezzo = 6},
            new Pizza{Id = 3,Nome= "Vegetariana", Prezzo = 7},
        };

        public List<Pizza> conto = new List<Pizza>() { };

        public void AddToConto(Pizza existPizza)
        {
            conto.Add(existPizza);
        }

        public int CalcolaConto(List<Pizza> pizzeScelte)
        {
            throw new NotImplementedException();
            //manca calcolo e sconti
        }

        public List<Pizza> GetAll()
        {
            return pizze;
        }

        public List<Pizza> GetAll(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti)
        {
            var tuttePizze = GetAll();

            //Unisco le tabelle con join
            var uniEntita = (from pizza in tuttePizze
                             join pizzaIngrediente in pizzeIngredienti on pizza.Id equals pizzaIngrediente.IdPizza
                             join ingrediente in ingredienti on pizzaIngrediente.IdIngr equals ingrediente.Id
                             select new PizzaWithIngrediente(pizza.Id, pizza.Nome, pizza.Prezzo, ingrediente.Nome));

            //var createPizza = from row in uniEntita
            //                  group row by row.Id into NewPizze
            //                  select new Pizza(){ Id = NewPizze.Key, Nome = NewPizze.Single().Nome, Ingredienti = NewPizze.Select(i =>  i.Nome).ToList(), Prezzo = NewPizze.Key };

            var createPizza = from row in uniEntita
                              group row by new
                              {
                                  row.IdPizza,
                                  row.Name,
                                  row.Price
                              } into NewPizze
                              select new Pizza() { Id = NewPizze.Key.IdPizza, Nome = NewPizze.Key.Name, Ingredienti = NewPizze.Select(i => i.NameIngrediente).ToList(), Prezzo = NewPizze.Key.Price };

            return createPizza.ToList();
        }


        public Pizza GetByName(string nome)
        {
            //var pizza = pizze.FirstOrDefault(p => p.Nome == nome);
            //return pizza;
            try
            {
                var pizza = from item in pizze
                            where item.Nome == nome
                            select item;

                return pizza.Single();
            }
            catch
            {
                Console.WriteLine("Qualcosa non va!");
                return null;
            }

        }

        public string GetConto()
        {
            try
            {
                int contoPrezzi = 0;
                string totaleDaPagare = "";

                foreach (Pizza pizza in conto)
                {
                    contoPrezzi += pizza.Prezzo;
                }
                totaleDaPagare = $"Totale da pagare: {contoPrezzi}";
                return totaleDaPagare;
            }
            catch (Exception)
            {
                Console.WriteLine("Qualcosa è andato storto!");
                return null;
            }

        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto, List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti)
        {
            var tuttePizze = GetAll();

            var uniEntita = (from pizza in tuttePizze
                             join pizzaIngrediente in pizzeIngredienti on pizza.Id equals pizzaIngrediente.IdPizza
                             join ingrediente in ingredienti on pizzaIngrediente.IdIngr equals ingrediente.Id
                             where ingrediente.Nome == ingredienteScelto
                             select new PizzaWithIngrediente(pizza.Id, pizza.Nome, pizza.Prezzo, ingrediente.Nome));

            var pizzeWithIngredients = from row in tuttePizze
                                       group row by new
                                       {
                                           row.Id,
                                           row.Nome,
                                           row.Prezzo,
                                       } into listIngredienti
                                       select new Pizza()
                                       {
                                           Nome = listIngredienti.Key.Nome,
                                           Id = listIngredienti.Key.Id,
                                           Prezzo = listIngredienti.Key.Prezzo,
                                           Ingredienti = listIngredienti.Select(i => i.Nome).ToList()
                                       };

            return pizzeWithIngredients.ToList();
        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto, List<Ingrediente> ingredienti, List<Pizza> pizzeIngredienti)
        {
            throw new NotImplementedException();
        }

        public struct PizzaWithIngrediente
        {
            public int IdPizza { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string NameIngrediente { get; set; }

            public PizzaWithIngrediente(int idPizza, string name, int price, string nameIngrediente)
            {
                IdPizza = idPizza;
                Name = name;
                Price = price;
                NameIngrediente = nameIngrediente;
            }

        }
    }

}

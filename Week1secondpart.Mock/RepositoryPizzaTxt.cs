using System;
using System.Collections.Generic;
using System.IO;
using Week1secondpart.Core;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Mock
{
    public class RepositoryPizzaTxt : IRepositoryPizza
    {
        const string path = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\MenuPizze.txt";
        const string pathConto = @"C:\Users\tereza.simkova\source\repos\Week1secondpart\Conto.txt";
        List<Pizza> pizze = new List<Pizza>();
        List<Pizza> contoPizze = new List<Pizza>();

        public Pizza Add(Pizza pizza)
        {
            using (StreamWriter sw = new StreamWriter(pathConto, true))
            {
                sw.WriteLine();
            }
            return pizza;
        }

        public void AddToConto(Pizza existPizza) //try catch
        {
            using (StreamWriter sw = new StreamWriter(pathConto, true))
            {
                sw.WriteLine($"{existPizza.Nome} - {existPizza.Prezzo}");
            }
            contoPizze.Add(existPizza);

        }

        public bool Delete(Pizza item)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
        {
            string menuPizze = string.Empty;
            string[] lines;

            using (StreamReader reader = new StreamReader(path))
            {
                menuPizze = reader.ReadToEnd();
            }
            lines = menuPizze.Split("\r\n");

            foreach (var l in lines)
            {
                string[] linesElement = l.Split("-");

                Pizza pizza = new Pizza();
                pizza.Nome = linesElement[0].Trim();
                pizza.Prezzo = Convert.ToInt32(linesElement[2].Trim());
                foreach (string ing in linesElement[1].Split(","))
                {
                    pizza.Ingredienti.Add(ing.Trim());
                }

                pizze.Add(pizza);

            }
            return pizze;

        }

        public List<Pizza> GetAll(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetByIngrediente(string ingrediente)
        {
            throw new NotImplementedException();
        }

        public Pizza GetByName(string nome)
        {
            GetAll();
            return pizze.Find(p => p.Nome == nome);

        }

        public string GetConto()
        {
            string menuPizze = string.Empty;
            int contoPrezzi = 0;
            string totaleDaPagare = "";
            string[] lines;

            using (StreamReader st = new StreamReader(pathConto))
            {
                menuPizze = st.ReadToEnd();
            };

            lines = menuPizze.Split("\r\n");

            foreach (var l in lines)
            {
                if (string.IsNullOrEmpty(l)) continue;
                string[] linesElement = l.Split("-");

                contoPrezzi += Convert.ToInt32(linesElement[1].Trim());

                //Pizza pizza = new Pizza();
                //pizza.Nome = linesElement[0].Trim();
                //    pizza.Prezzo = Convert.ToInt32(linesElement[2].Trim());
                //    foreach (string ing in linesElement[1].Split(","))
                //    {
                //        pizza.Ingredienti.Add(ing.Trim());
                //    }

                //    pizze.Add(pizza);
                //}

                //foreach (Pizza item in pizze)
                //{
                //    contoPrezzi += item.Prezzo;
                //}
                //totaleDaPagare = $"Totale da pagare: {contoPrezzi}";

                //return totaleDaPagare;
            }
            totaleDaPagare = $"Totale da pagare: {contoPrezzi}";

            return totaleDaPagare;
        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto)
        {
            throw new NotImplementedException();
        }

        public Pizza Update(Pizza item)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {

        private readonly IRepositoryPizza pizzaRepo;
        private readonly IRepositoryIngredienti ingRepo;
        private readonly IPizzaIngrediente ingEpizzaRepo;
        public MainBusinessLayer(IRepositoryPizza repositoryPizza, IRepositoryIngredienti repositoryIngredienti, IPizzaIngrediente pizzaIngrediente)
        {
            pizzaRepo = repositoryPizza;
            ingRepo = repositoryIngredienti;
            ingEpizzaRepo = pizzaIngrediente;
        }

        public List<Pizza> SeeAllPizza()
        {
            var ingredienti = ingRepo.GetAll();
            var pizzeIngredienti = ingEpizzaRepo.GetAll();
            return pizzaRepo.GetAll(ingredienti,pizzeIngredienti);
        }

        public Pizza GetByName(string nome)
        {
            Pizza existPizza = pizzaRepo.GetByName(nome);
            
            if (nome == "Marinara" || nome == "Margherita" || nome == "Vegetariana")
            {
                pizzaRepo.AddToConto(existPizza);
                Console.WriteLine("Pizza aggiunta al carello con successo!");
            }
            return existPizza;
        }

        public string GetContoPizze()
        {
            var contoPizze = pizzaRepo.GetConto();
            if (contoPizze == null)
            {
                return "Non ce nessun conto da pagare!";
            }
            else
            {
                return contoPizze;
            }
        }

        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto)
        {
            var ingredienti = ingRepo.GetAll();
            var pizzeIngredienti = pizzaRepo.GetAll();
            return pizzaRepo.GetPizzeByIngrediente(ingredienteScelto, ingredienti, pizzeIngredienti);
        }

        public List<Ingrediente> SeeAllIngredienti()
        {
            throw new NotImplementedException();
        }

        public void StampaScontrino(List<Pizza> pizzeScelte)
        {
            int totale = pizzaRepo.CalcolaConto(pizzeScelte);
        }

    }
}

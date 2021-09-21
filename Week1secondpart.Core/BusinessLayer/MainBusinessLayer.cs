using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryPizza pizzaRepo;
        public MainBusinessLayer(IRepositoryPizza repositoryPizza)
        {
            pizzaRepo = repositoryPizza;
        }

        public List<Pizza> SeeAllPizza()
        {
            return pizzaRepo.GetAll();
        }

        public string GetByName(string nome)
        {
            if (nome == null)
            {
                return "La pizza non esiste!";
            }

            var existPizza = pizzaRepo.GetByName(nome);
          
            if (nome == "Marinara" || nome == "Margherita" || nome == "Vegetariana")
            {
                pizzaRepo.AddToConto(existPizza);
                return "Pizza aggiunta con successo!";
            }
            else
            {
                return "La pizza non esiste!";
            }
            
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

        public List<Pizza> FiltraPerIngrediente(string ingrediente)
        {
            return pizzaRepo.GetByIngrediente(ingrediente);

        }
    }
}

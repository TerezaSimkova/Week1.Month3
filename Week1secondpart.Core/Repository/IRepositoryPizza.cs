using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;

namespace Week1secondpart.Core.Repository
{
    public interface IRepositoryPizza : IRepository<Pizza>
    {
        public Pizza GetByName(string nome);
        void AddToConto(Pizza existPizza);
        public string GetConto();
        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto);
        List<Pizza> GetAll(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti);
        List<Pizza> GetPizzeByIngrediente(string ingredienteScelto, List<Ingrediente> ingredienti, List<Pizza> pizzeIngredienti);
        public int CalcolaConto(List<Pizza> pizzeScelte);
    }
}

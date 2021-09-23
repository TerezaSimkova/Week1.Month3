using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;

namespace Week1secondpart.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Pizza> SeeAllPizza();
        public List<Ingrediente> SeeAllIngredienti();
        public Pizza GetByName(string nome);
        public string GetContoPizze();
        public List<Pizza> GetPizzeByIngrediente(string ingredienteScelto);
        public void StampaScontrino(List<Pizza> pizzeScelte);
    }
}

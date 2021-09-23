using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;
using Week1secondpart.Core.Repository;

namespace Week1secondpart.Mock
{
    public class RepositoryIngredientiMock : IRepositoryIngredienti
    {
        public static List<Ingrediente> ingredienti = new List<Ingrediente>()
        {
            new Ingrediente(1,"pomodoro"),
            new Ingrediente(2,"mozzarella"),
            new Ingrediente(3,"basilico"),
            new Ingrediente(4,"acciughe"),
            new Ingrediente(5,"verdure_grigliate"),
            new Ingrediente(6,"olive"),
            new Ingrediente(7,"friarielli"),
        };

        public List<Ingrediente> GetAll()
        {
            return ingredienti;
        }

        public string GetByIngredienteNome(string ingrediente)
        {
            return ingredienti.FirstOrDefault(i => i.Nome == ingrediente).ToString();           
        }
    }
}

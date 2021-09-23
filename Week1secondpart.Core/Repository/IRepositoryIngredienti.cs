using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1secondpart.Core.Entities;

namespace Week1secondpart.Core.Repository
{
    public interface IRepositoryIngredienti : IRepository<Ingrediente>
    {
        string GetByIngredienteNome(string ingrediente);
    }
}

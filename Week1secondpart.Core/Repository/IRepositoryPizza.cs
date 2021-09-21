using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1secondpart.Core.Repository
{
    public interface IRepositoryPizza : IRepository<Pizza>
    {
        public Pizza GetByName(string nome);
        void AddToConto(Pizza existPizza);
    }
}

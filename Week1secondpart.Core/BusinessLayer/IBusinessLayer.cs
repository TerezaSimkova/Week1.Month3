using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1secondpart.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Pizza> SeeAllPizza();
        public string GetSpesa();
        public string GetByName(string nome);
    }
}

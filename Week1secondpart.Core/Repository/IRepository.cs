using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1secondpart.Core.Repository
{
    public interface IRepository<T>
    {
        public List<T> GetAll(); 
        //public T Add(T item); 
        //public T Update(T item);
        //public bool Delete(T item); 
    }
}

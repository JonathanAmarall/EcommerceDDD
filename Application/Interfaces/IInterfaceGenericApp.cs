using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IInterfaceGenericApp<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task<Product> GetEntityById(int Id);
        Task<List<T>> List();
        Task Delete(T Objeto);
    }
}

using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceProduct
{
    public interface IProduct: IGeneric<Product>
    {
        Task<List<Product>> ListProductFromUser(string userId);

        Task<List<Product>> ListProductsFromStock(Expression<Func<Product, bool>> exProduct);
    }
}

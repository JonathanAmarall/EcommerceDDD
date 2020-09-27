using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : IInterfaceProductApp
    {
        IProduct _product;
        IServiceProduct _ServiceProduct;

        public AppProduct(IProduct product, IServiceProduct serviceProduct)
        {
            _product = product;
            _ServiceProduct = serviceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _ServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _ServiceProduct.UpdateProduct(product);
        }

        public async Task Add(Product Objeto)
        {
            await _product.Add(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _product.Delete(Objeto);
        }
        public async Task<Product> GetEntityById(int Id)
        {
            return await _product.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _product.List();
        }

        public async Task Update(Product Objeto)
        {
            await _product.Update(Objeto);
        }


    }
}

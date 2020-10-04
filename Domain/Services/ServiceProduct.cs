using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _product;
        public ServiceProduct(IProduct product)
        {
            _product = product;
        }

        public async Task AddProduct(Product product)
        {
            var validName = product.ValidatePropertyString(product.Nome, "Name");

            var validValue = product.ValidatePropertyDecimal(product.Valor, "Value");

            var validQntEstoque = product.ValidatePropertyInt(product.QtdEstoque, "QtdEstoque");

            if (validName && validValue && validQntEstoque)
            {
                product.Estado = true;

                product.DataCadastro = DateTime.Now;

                await _product.Add(product);
            }

        }

        public async Task<List<Product>> ListProductsWithStock()
        {
            return await _product.ListProductsFromStock(p => p.QtdEstoque > 0);
        }

        public async Task UpdateProduct(Product product)
        {
            var validName = product.ValidatePropertyString(product.Nome, "Name");

            var validValue = product.ValidatePropertyDecimal(product.Valor, "Value");

            var validQntEstoque = product.ValidatePropertyInt(product.QtdEstoque, "QtdEstoque");


            if (validName && validValue && validQntEstoque)
            {
                product.DataAlteracao = DateTime.Now;

                await _product.Update(product);
            }
        }
    }
}

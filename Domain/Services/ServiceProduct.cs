using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
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

            if (validName && validValue)
            {
                product.Estado = true;

                await _product.Add(product);
            }

        }

        public async Task UpdateProduct(Product product)
        {
            var validName = product.ValidatePropertyString(product.Nome, "Name");

            var validValue = product.ValidatePropertyDecimal(product.Valor, "Value");

            if (validName && validValue)
            {
                await _product.Update(product);
            }
        }
    }
}

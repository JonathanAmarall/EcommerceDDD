﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IInterfaceProductApp : IInterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);

        Task<List<Product>> ListProductFromUser(string userId);

        Task<List<Product>> ListProductsFromStock();

    }
}

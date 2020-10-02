﻿using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceProduct
{
    public interface IProduct: IGeneric<Product>
    {
        Task<List<Product>> ListProductFromUser(string userId);
    }
}

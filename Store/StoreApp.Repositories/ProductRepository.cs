﻿using StoreApp.Entities.Models;
using StoreApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);
        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p => p.ProductID.Equals(id), trackChanges);
        }

    }
}

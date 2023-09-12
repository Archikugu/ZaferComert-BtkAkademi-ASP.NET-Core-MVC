using StoreApp.Entities.Models;
using StoreApp.Repositories.Contracts;
using StoreApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _repositoryManager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, trackChanges);
            if (product is null)
            {
                throw new Exception("Product Not Found!");
            }
            return product;
        }
    }
}

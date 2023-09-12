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
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _repositoryManager.Category.FindAll(trackChanges);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StoreApp.Entities.Models;
using StoreApp.Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            var model = _repositoryManager.Category.FindAll(false);
            return View(model);
        }
    }
}

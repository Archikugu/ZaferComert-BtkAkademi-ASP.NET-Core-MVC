using Microsoft.AspNetCore.Mvc;
using StoreApp.Entities.Models;
using StoreApp.Repositories.Contracts;
using StoreApp.Services.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public CategoryController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var model = _serviceManager.CategoryService.GetAllCategories(false);
            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Entities.Models;
using StoreApp.Repositories;
using StoreApp.Repositories.Contracts;
using StoreApp.Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var model = _serviceManager.ProductService.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            var model = _serviceManager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}

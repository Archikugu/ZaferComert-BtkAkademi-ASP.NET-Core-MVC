using Microsoft.AspNetCore.Mvc;
using StoreApp.Entities.Models;
using StoreApp.Services.Contracts;

namespace StoreApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly Cart _cart;

        public OrderController(IServiceManager serviceManager, Cart cart)
        {
            _serviceManager = serviceManager;
            _cart = cart;
        }

        public ViewResult CheckOut() => View(new Order());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut([FromForm] Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _serviceManager.OrderService.SaveOrder(order);
                _cart.Clear();
                return RedirectToPage("/Complete", new { OrderIds = order.OrderID });
            }
            else
            {
                return View();
            }
        }

    }
}

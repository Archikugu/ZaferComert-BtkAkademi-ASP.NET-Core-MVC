using Microsoft.AspNetCore.Mvc;
using StoreApp.Entities.Models;

namespace StoreApp.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Cart _cart;

        public CartSummaryViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public string Invoke()
        {
            return _cart.Lines.Count().ToString();
        }
    }
}

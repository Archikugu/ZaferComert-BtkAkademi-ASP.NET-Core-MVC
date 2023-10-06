using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreApp.Entities.Models;
using StoreApp.Services.Contracts;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;
       
        public Cart Cart { get; set; }

        public CartModel(IServiceManager manager, Cart cart)
        {
            _manager = manager;
            Cart = cart;
        }

        public string ReturnUrl { get; set; } = "/";
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int productID, string returnUrl)
        {
            Product? product = _manager.ProductService.GetOneProduct(productID, false);
            if (product != null)
            {
                Cart.AddItem(product, 1);
            }
            return Page();
        }
        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(x => x.Product.ProductID == id).Product);
            return Page();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace StoreApp.ViewComponents
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

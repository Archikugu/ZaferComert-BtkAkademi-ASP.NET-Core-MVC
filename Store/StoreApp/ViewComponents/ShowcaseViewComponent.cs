﻿using Microsoft.AspNetCore.Mvc;
using StoreApp.Services.Contracts;

namespace StoreApp.ViewComponents
{
    public class ShowcaseViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public ShowcaseViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var products = _serviceManager.ProductService.GetShowcaseProducts(false);
            return View(products);
        }
    }
}
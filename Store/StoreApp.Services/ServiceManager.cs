using StoreApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;

        public ServiceManager(ICategoryService categoryService, IProductService productService, IOrderService orderService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public IOrderService OrderService => _orderService;
    }
}

using Microsoft.AspNetCore.Mvc;
using StoreApp.Services.Contracts;

namespace StoreApp.ViewComponents
{
    public class OrderInProgressViewComponent : ViewComponent
    {

        private readonly IServiceManager _manager;

        public OrderInProgressViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
                .OrderService
                .NumberOfInProcess
                .ToString();
        }
    }
}

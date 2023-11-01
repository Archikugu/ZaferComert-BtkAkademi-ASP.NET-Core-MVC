using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IOrderRepository Order { get; }
        void Save();
    }
}

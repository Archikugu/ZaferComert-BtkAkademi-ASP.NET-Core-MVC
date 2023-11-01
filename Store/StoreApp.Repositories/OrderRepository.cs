using Microsoft.EntityFrameworkCore;
using StoreApp.Entities.Models;
using StoreApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Order> Orders => _context.Orders
            .Include(o => o.Lines)
            .ThenInclude(cl => cl.Product)
            .OrderBy(o => o.Shipped)
            .ThenByDescending(o => o.OrderID);

        public int NumberOfInProcess =>
            _context.Orders.Count(o => o.Shipped.Equals(false));

        public void Complete(int id)
        {
            var order = FindByCondition(o => o.OrderID.Equals(id), true);
            if (order is null)
                throw new Exception("Order could not found!");
            order.Shipped = true;
        }

        public Order? GetOneOrder(int id)
        {
            return FindByCondition(o => o.OrderID.Equals(id), false);
        }

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
                _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }
        public Cart()
        {
            Lines = new List<CartLine>();
        }
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(x => x.Product.ProductID == product.ProductID).FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product) => Lines.RemoveAll(x => x.Product.ProductID == product.ProductID);
        public decimal ComputeTotalValue() => Lines.Sum(x => x.Product.Price * x.Quantity);
        public void Clear() => Lines.Clear();
    }
}

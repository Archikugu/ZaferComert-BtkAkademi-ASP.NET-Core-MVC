using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}

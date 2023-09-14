using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Product Name is Required.")]
        public string? ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is Required.")]
        public decimal Price { get; set; }
    }
}

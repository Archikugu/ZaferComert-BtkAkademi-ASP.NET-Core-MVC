using StoreApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Dtos
{
    public record ProductDto
    {
        public int ProductID { get; init; }
        [Required(ErrorMessage = "Product Name is Required.")]
        public string? ProductName { get; init; } = string.Empty;

        [Required(ErrorMessage = "Price is Required.")]
        public decimal Price { get; init; }
        public string? Summary { get; init; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int? CategoryID { get; init; }

    }
}

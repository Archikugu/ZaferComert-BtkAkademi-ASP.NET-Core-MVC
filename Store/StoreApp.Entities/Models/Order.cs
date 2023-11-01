using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Models
{
    public class Order
    {

        public int OrderID { get; set; }
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

        [Required(ErrorMessage = "Name Is Required")]
        public String? Name { get; set; }

        [Required(ErrorMessage = "Line1 Is Required")]
        public String? Line1 { get; set; }
        public String? Line2 { get; set; }
        public String? Line3 { get; set; }
        public String? City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Shipped { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;
    }
}

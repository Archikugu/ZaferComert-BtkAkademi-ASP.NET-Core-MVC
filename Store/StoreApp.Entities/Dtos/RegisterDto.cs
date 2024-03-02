using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "Username is required")]
        public String? UserName { get; init; }

        [Required(ErrorMessage = "Email is required")]
        public String? Email { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public String? Password { get; init; }
    }
}

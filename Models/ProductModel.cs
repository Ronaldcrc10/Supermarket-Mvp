using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Product price must be greater than zero")]
        public int Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Product stock must be zero or greater")]
        public int Stock { get; set; }
    }
}

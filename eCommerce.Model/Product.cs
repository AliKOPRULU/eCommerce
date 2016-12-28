using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Description { get; set; }

        [StringLength(250)]
        public string ImageUrl { get; set; }

        [Range(0, 999.99)]
        public decimal Price { get; set; }

        [Range(0,999.99)]
        public decimal CostPrice { get; set; }
    }
}

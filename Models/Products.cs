using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/*
 * Name = Lovish Grover
 * Student id = 100760852
 * NetD 3202
 */

namespace Lab5.Models
{
    public class Products
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }

        public string productDescription { get; set; }

        public string productBrand { get; set; }
    }
}

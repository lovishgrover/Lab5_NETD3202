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
    
    public class Customers
    {
        [Key]
        public int custId { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string issue { get; set; }

        public int phNumber { get; set; }

        public ICollection<Services> Services { get; set; }
    }
}

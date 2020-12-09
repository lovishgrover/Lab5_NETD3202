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
    public class Services
    {
        [Key]
        public int serviceId { get; set; }

        public Customers custId { get; set; }

        public string description { get; set; }

        public string productNeeded { get; set; }
    }
}

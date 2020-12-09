using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{
    public class Lab5_Context : DbContext
    {
        public Lab5_Context(DbContextOptions<Lab5_Context> options) : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Services> Services { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}

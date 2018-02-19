using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestProjectsHosting.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext():base("ProductDbContext")
        {
            
        }
        public virtual DbSet<Product> Products { get; set; }

    }
}
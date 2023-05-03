using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Delivery : DbContext
    {

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
       // public virtual DbSet<Restaurant> Restaurants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           //  base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=mydb;trusted_connection=true");
    }
}

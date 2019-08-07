using PizzaAppWithAspMebership.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaHelpCenterAppV1.Models
{
    public class OrderDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
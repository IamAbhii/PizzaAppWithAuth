using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PizzaAppWithAspMebership.Models
{
    public class Order 
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string PizzaSize { get; set; }
        public int Quantity { get; set; }
        public double PizzaPrice { get; set; }
        public DateTime TimeOFOrderCreated { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaAppWithAspMebership.Models
{
    public class Customer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
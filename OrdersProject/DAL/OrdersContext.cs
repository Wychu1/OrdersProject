using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OrdersProject.Views.Entities;

namespace OrdersProject.DAL
{
    public class OrdersContext : DbContext
    {
        public OrdersContext() : base("OrdersContext")
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
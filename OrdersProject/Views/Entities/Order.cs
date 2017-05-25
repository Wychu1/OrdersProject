using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrdersProject.Views.Entities
{
    public enum Agency
    {
        Egp,
        Tbwa,
        Tbwapr,
        Tequila

    }
    public class Order
    {
        public long Id { get; set; }
        public Agency Agency { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public bool PaymentStatus { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }

    }
}
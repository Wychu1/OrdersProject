using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrdersProject.Models
{
    public class OrderViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public long ContractorId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; }
        public long UserId { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
    }
}
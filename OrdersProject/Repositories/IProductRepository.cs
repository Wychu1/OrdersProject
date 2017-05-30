using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrdersProject.Models;

namespace OrdersProject.Repositories
{
        public interface IProductRepository
        {
            IEnumerable<ProductViewModel> GetProducts();
        }
}
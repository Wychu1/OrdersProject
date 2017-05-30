using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrdersProject.DAL;
using OrdersProject.Models;

namespace OrdersProject.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly OrderContext _dbContext;

        public ProductRepository(OrderContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return _dbContext.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
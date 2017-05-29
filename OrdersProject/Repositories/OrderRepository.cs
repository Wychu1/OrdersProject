using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrdersProject.DAL;
using OrdersProject.Models;

namespace OrdersProject.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _dbContext;

        public OrderRepository(OrderContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OrderViewModel> GetOrders()
        {


            return _dbContext.Orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CompanyId = x.CompanyId,
                ProductId = x.ProductId,
                ContractorId = x.ContractorId,
                UserId = x.UserId,
                Price = x.Cost,
                Seller = x.Seller,
                Buyer = x.Buyer


            });
        }

    }
}
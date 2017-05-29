using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrdersProject.Repositories;
using OrdersProject.Views.Entities;

namespace OrdersProject.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepository _repository;

        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }

        // GET: Order
        public ActionResult List()
        {
            var orders = _repository.GetOrders();

            return View(orders);
        }
    }
}
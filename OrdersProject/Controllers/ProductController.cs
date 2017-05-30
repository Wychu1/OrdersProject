using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrdersProject.Repositories;

namespace OrdersProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        // GET: Product
        public ActionResult List()
        {
            var products = _repository.GetProducts();

            return View(products);
        }
    }
}
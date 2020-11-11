using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;
using ShoppingCart.Application.ViewModels;


namespace Presentation.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsService _productsService;
        public ProductsController(IProductsService productsService) {
            _productsService = productsService;
        }

        public IActionResult Index()
        {
            var list = _productsService.GetProducts().OrderByDescending(x=>x.Price).Where(x=>x.Price > 100);
            return View(list);
        }
    }
}

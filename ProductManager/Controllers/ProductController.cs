using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            using(var context = new PRN_projectContext())
            {
                products = context.Products.ToList();
            }
            return View(products);
        }
    }
}

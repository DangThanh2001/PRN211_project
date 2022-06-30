using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Logics;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        PrdManager dao = new PrdManager();
        public IActionResult Index()
        {
            List<Product> products = dao.getALlProduct();
            
            return View(products);
        }
    }
}

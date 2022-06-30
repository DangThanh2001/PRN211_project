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
        public IActionResult Index(string par1)
        {
            ViewBag.here = "pro";
            List<Product> products = dao.getALlProduct(par1);
            ViewBag.seacrh = par1;
            return View(products);
        }

        public IActionResult detail(int par1)
        {
            ViewBag.here = "pro";
            Product p = dao.updateProduct(par1);
            List<Category> cat = dao.viewCategoryByPro(par1);
            ViewBag.cate = cat;
            ViewBag.IDate = p.ImportDate.ToString("dd/MM/yyyy");
            return View(p);
        }

        public string listCompany()
        {
            return "nothing yet";
        }

        public IActionResult search(string par1)
        {
            ViewBag.here = "pro";
            if (string.IsNullOrEmpty(par1))
            {
                List<Product> p = dao.searchByName(par1);
                return RedirectToAction("index", new { par1 = p });
            }
            List<Product> products = dao.searchByName(par1);
            return RedirectToAction("index", new { par1 = products });

        }
    }
}

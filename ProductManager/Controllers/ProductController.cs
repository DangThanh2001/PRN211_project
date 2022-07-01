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
            Product p = dao.viewProduct(par1);
            List<Category> cat = dao.viewCategoryByPro(par1);
            ViewBag.cate = cat;
            ViewBag.IDate = p.ImportDate.ToString("dd/MM/yyyy");
            return View(p);
        }

        public IActionResult status(int par1)
        {
            Product pr = dao.viewProduct(par1);
            dao.changeStatus(par1);
            List<Product> products = dao.getALlProduct(pr.ProductName);
            ViewBag.here = "pro";
            ViewBag.seacrh = pr.ProductName;
            return RedirectToAction("index", "product");
        }

        public IActionResult quantity(Product upPro)
        {
            Product pr = dao.viewProduct(upPro.ProductId);
            pr.Quantity = upPro.Quantity;
            if(pr.Quantity > 0)
            {
                dao.updateProduct(pr);
            }
            if(pr.Quantity == 0)
            {
                pr.Status = 0;
                dao.updateProduct(pr);
            }
            if(pr.Quantity < 0)
            {
                string mess = @"Man, please input positive interger pls";
                ViewBag.mess = mess;
                return RedirectToAction("index", "product");
            }
            List<Product> products = dao.getALlProduct(pr.ProductName);
            ViewBag.here = "pro";
            ViewBag.seacrh = pr.ProductName;
            return RedirectToAction("index", "product");
        }
    }
}

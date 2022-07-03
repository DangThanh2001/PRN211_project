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
            if (string.IsNullOrEmpty(par1))
                par1 = "";
            ViewBag.seacrh = par1;

            List<PublishingHouse> allCom = dao.showAllCompany("");
            ViewBag.allCom = allCom;
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
                
                return RedirectToAction("index", "product");
            }
            List<Product> products = dao.getALlProduct(pr.ProductName);
            ViewBag.here = "pro";
            ViewBag.seacrh = pr.ProductName;
            return RedirectToAction("index", "product");
        }

        public IActionResult listStatus(int par1)
        {
            ViewBag.here = "pro";
            ViewBag.seacrh = "";
            ViewBag.stt = par1;
            List<Product> products = dao.getPrdBystatus(par1);
            List<PublishingHouse> allCom = dao.showAllCompany("");
            ViewBag.allCom = allCom;
            if (par1 == 0 || par1 == 1)
                return View(products);
            else
                return RedirectToAction("index");
        }

        public IActionResult update(int par1)
        {
            ViewBag.here = "pro";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you submit";
            List<PublishingHouse> pub = dao.showAllCompany("");
            ViewBag.pub = pub;
            Product p = dao.viewProduct(par1);
            return View(p);
        }

        public IActionResult doupdate(Product updatePr)
        {
            ViewBag.here = "pro";
            Product p = updatePr;
            if (updatePr.Status > 0 && updatePr.Quantity <= 0)
			{
                ViewBag.ok = 0;
                ViewBag.mess = "Your work has something not right... pls check again :< ";
			}
			else
			{
                ViewBag.ok = 1;
                dao.updateProduct(updatePr);
                ViewBag.mess = "Your work has done successfully";
            }
            ViewBag.pub = dao.showAllCompany("");
            return View("/views/product/update.cshtml", p);
        }
    }
}

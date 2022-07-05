using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Logics;
using ProductManager.Models;
using System.Collections.Generic;

namespace ProductManager.Controllers
{
    public class CategoryController : Controller
    {
        PrdManager dao = new PrdManager();
        public bool checkLogin()
        {
            string? user = HttpContext.Session.GetString("user");
            if (string.IsNullOrEmpty(user))
                return false;
            else
                return true;
        }

        public IActionResult Index(string par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "tag";
            ViewBag.mess = @"If you delete category, 
all other relevant information will be lost!!!";
            ViewBag.seacrh = par1;
            List<Category> cate = dao.allCategory(par1);
            return View(cate);
        }

        public IActionResult delete(int par1)
        {
            ViewBag.here = "tag";
            dao.deleteCat(par1);
            
            return RedirectToAction("index");
        }
    }
}

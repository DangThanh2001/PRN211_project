using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public string getUserName()
        {
            string? user = HttpContext.Session.GetString("user");
            if (string.IsNullOrEmpty(user))
                return "";
            else
            {
                Admin ad = JsonConvert.DeserializeObject<Admin>(user);
                return ad.FullName;
            }
        }

        public IActionResult Index(string par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag";
            ViewBag.mess = @"If you delete category, 
all other relevant information will be lost!!!";
            ViewBag.seacrh = par1;
            List<Category> cate = dao.allCategory(par1);
            return View(cate);
        }

        public IActionResult delete(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag"; 
            ViewBag.mess = @"Your work has done successfully!!!";
            dao.deleteCat(par1);
            List<Category> cate = dao.allCategory();
            return View("/views/category/index.cshtml", cate);
        }

        public IActionResult update(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag";
            ViewBag.ok = 1;
            ViewBag.mess =  "Please check your work before you submit";
            Category cate = dao.getCat(par1);
            return View(cate);
        }

        public IActionResult doupdate(Category upCat)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag";
            ViewBag.ok = 1;
            dao.updateCate(upCat);
            ViewBag.mess = "Your work has done successfully";
            return View("/views/category/update.cshtml", upCat);
        }

        public IActionResult add()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag";
            ViewBag.ok = 1;
            ViewBag.act = "add";
            ViewBag.mess = "Please check your work before you submit";
            Category cate = new Category();
            return View("/views/category/update.cshtml", cate);
        }

        public IActionResult doadd(Category upCat)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.user = getUserName();
            ViewBag.here = "tag";
            ViewBag.ok = 1;
            dao.updateCate(upCat);
            ViewBag.mess = "Your work has done successfully";
            return View("/views/category/update.cshtml", upCat);
        }
    }
}

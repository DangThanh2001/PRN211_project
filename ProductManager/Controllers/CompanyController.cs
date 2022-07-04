using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Logics;
using ProductManager.Models;
using System.Collections.Generic;

namespace ProductManager.Controllers
{
    public class CompanyController : Controller
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

            ViewBag.here = "comp";
            List<PublishingHouse> a = dao.showAllCompany(par1);
            return View(a);
        }

        public IActionResult detail(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "comp";
            PublishingHouse a = dao.getCompany(par1);
            return View(a);
        }

        public IActionResult update(int par1)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "comp";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you save";
            PublishingHouse a = dao.getCompany(par1);
            return View(a);
        }

        public IActionResult doupdate(PublishingHouse comp)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "comp";
            if (!string.IsNullOrEmpty(comp.Note))
            {
                string newNote = comp.Note.Trim();
                comp.Note = newNote;
            }
            if (dao.isPhone(comp.Phone))
            {
                ViewBag.ok = 1;
                dao.updateCom(comp);
                ViewBag.mess = "This company has updated successfully!";
            }
            else
            {
                ViewBag.ok = 0;
                ViewBag.mess = "check your phone number again pls";
            }
            return View("/views/company/update.cshtml", comp);
        }

        public IActionResult add()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "comp";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you save";
            PublishingHouse a = new PublishingHouse();
            return View("/views/company/update.cshtml", a);
        }

        public IActionResult doadd(PublishingHouse comp)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }

            ViewBag.here = "comp";
            if (!string.IsNullOrEmpty(comp.Note))
            {
                string newNote = comp.Note.Trim();
                comp.Note = newNote;
            }
            if (dao.isPhone(comp.Phone))
            {
                ViewBag.ok = 1;
                dao.updateCom(comp);
                ViewBag.mess = "This company has added successfully!";
            }
            else
            {
                ViewBag.ok = 0;
                ViewBag.mess = "check your phone number again pls";
            }
            return View("/views/company/update.cshtml", comp);
        }
    }
}

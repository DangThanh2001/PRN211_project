using Microsoft.AspNetCore.Mvc;
using ProductManager.Logics;
using ProductManager.Models;
using System.Collections.Generic;

namespace ProductManager.Controllers
{
    public class CompanyController : Controller
    {
        PrdManager dao = new PrdManager();
        public IActionResult Index(string par1)
        {
            ViewBag.here = "comp";
            List<PublishingHouse> a = dao.showAllCompany(par1);
            return View(a);
        }

        public IActionResult detail(int par1)
        {
            ViewBag.here = "comp";
            PublishingHouse a = dao.getCompany(par1);
            return View(a);
        }

        public IActionResult update(int par1)
        {
            ViewBag.here = "comp";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you save";
            PublishingHouse a = dao.getCompany(par1);
            return View(a);
        }

        public IActionResult doupdate(PublishingHouse comp)
        {
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
            ViewBag.here = "comp";
            ViewBag.ok = 1;
            ViewBag.mess = "Please check your work before you save";
            PublishingHouse a = new PublishingHouse();
            return View("/views/company/update.cshtml", a);
        }

        public IActionResult doadd(PublishingHouse comp)
        {
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

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
    }
}

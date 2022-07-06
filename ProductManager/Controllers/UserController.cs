using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductManager.Logics;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    public class UserController : Controller
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

        public IActionResult profile()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }
            ViewBag.here = "";
            ViewBag.user = getUserName();
            string? user = HttpContext.Session.GetString("user");
            Admin ad = JsonConvert.DeserializeObject<Admin>(user);

            return View(ad);
        }

        public IActionResult password()
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }
            ViewBag.here = "";
            ViewBag.user = getUserName();

            string? user = HttpContext.Session.GetString("user");
            Admin ad = JsonConvert.DeserializeObject<Admin>(user);

            return View(new Admin());
        }

        public IActionResult dopass(Admin pass)
        {
            if (!checkLogin())
            {
                ViewBag.mess = "Access Denied".ToUpper();
                return View("/views/product/login.cshtml", new Admin());
            }
            ViewBag.here = "";
            ViewBag.user = getUserName();
            string? user = HttpContext.Session.GetString("user");
            Admin ad = JsonConvert.DeserializeObject<Admin>(user);
            if(!ad.Password.Equals(pass.Password))
			{
                ViewBag.mess = @"Current password is not right";
                return View("/views/user/password.cshtml", pass);
            }
            if (ad.Password.Equals(pass.Password))
            {
                ViewBag.mess = @"Current password and new password can't be same";
                return View("/views/user/password.cshtml", pass);
            }
            if (!pass.FullName.Equals(pass.Email))
			{
                ViewBag.mess = @"New and re-new password not same";
                return View("/views/user/password.cshtml", pass);
            }
            dao.changePass(ad, pass.FullName);
            ViewBag.mess = @"Your password had change successfully";
            return View("/views/user/password.cshtml", new Admin());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginProject.ViewModels;

namespace LoginProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(HomeViewModel hvm)
        {
            if (hvm.home.Username.Equals("jayaprakash") && hvm.home.Password.Equals("8658"))
            {
                Session["username"] = hvm.home.Username;
                return View("Welcome");
            }
            else
            {
                ViewBag.Error = "Invalid Username & Password";
                return View("Index");
            }
        }
        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}
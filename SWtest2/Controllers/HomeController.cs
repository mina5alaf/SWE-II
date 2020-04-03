using SWtest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.BLogic;
namespace SWtest2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       /* public ActionResult Listalluser()
        {
            ViewBag.Message = "User Lists";
            var data = LoadUser();

            return View();
        }*/
        public ActionResult Signup()
        {
            ViewBag.Message = "User Sign up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(User u)
        {
            if (ModelState.IsValid)
            {
                int recordnum=Userprocessor.createuser(u.Fullname,u.Username,u.Email,u.password);
                return RedirectToAction("index");
            }

            return View();
        }
    }
}
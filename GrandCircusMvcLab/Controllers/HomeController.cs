using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandCircusMvcLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login(string name, string lastName, string email, string password, string address, bool deluxe = false)
        {
            ViewBag.Name = name + " " + lastName;
            ViewBag.Email = email;
            ViewBag.Password = password;
            ViewBag.Address = address;
            ViewBag.Deluxe = deluxe;
                    

            return View();
        }



        //----------------------------------------------------------------------------------------------------------------------------
        public ActionResult About()
        {
            ViewBag.Message = "We sell da beans!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more info...";

            return View();
        }
    }
}
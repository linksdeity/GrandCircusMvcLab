using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrandCircusMvcLab.Models;

namespace GrandCircusMvcLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDB ORM = new CoffeeShopDB();

            ViewBag.Beans = ORM.Items.ToList();

            return View();
        }



        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login(string firstname, string lastName, string email, string password, string address)
        {
            ViewBag.Name = firstname + " " + lastName;
            ViewBag.Email = email;
            ViewBag.Password = password;
            ViewBag.Address = address;
                    

            return View();
        }

        public ActionResult NewUser (User user)
        {

            CoffeeShopDB ORM = new CoffeeShopDB();

            foreach (var listUser in ORM.Users)
            {
                if(listUser.Email.ToLower() == user.Email.ToLower())
                {
                    string error = "Email match found!  " + user.Email + " is an email match!";
                    ViewBag.Error = error;
                    return View("Registration");
                }

            }

            ORM.Users.Add(user);
            ORM.SaveChanges();
            return RedirectToAction("UserIndex");
        }

        public ActionResult UserIndex()
        {
            CoffeeShopDB ORM = new CoffeeShopDB();

            ViewBag.Users = ORM.Users.ToList();

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
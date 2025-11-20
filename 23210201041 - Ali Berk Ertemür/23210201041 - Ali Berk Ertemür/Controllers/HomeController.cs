using _23210201041___Ali_Berk_Ertemür.Context;
using _23210201041___Ali_Berk_Ertemür.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23210201041___Ali_Berk_Ertemür.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private OdevContext context = new OdevContext();

        public ActionResult Index()
        {
            var sliders = context.Sliders.ToList();
            ViewBag.Slider1 = sliders.FirstOrDefault(m => m.SliderId == 1).SliderLink;
            ViewBag.Slider2 = sliders.FirstOrDefault(m => m.SliderId == 2).SliderLink;
            ViewBag.Slider3 = sliders.FirstOrDefault(m => m.SliderId == 3).SliderLink;
            return View(context.Users.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TableUser user)
        {
            ModelState.Remove("Name");
            ModelState.Remove("UserName");
            if (ModelState.IsValid)
            {
                var userinput = context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                if (userinput != null)
                {
                    Session["UserID"] = userinput.Id;
                    Session["UserName"] = userinput.UserName;
                    Session["Password"] = userinput.Password;
                    Session["UserRole"] = userinput.RoleID;

                    if (Session["UserRole"].Equals(1))
                    {
                        Session["Role"] = "Admin";
                        return RedirectToAction("Index", "Admin");
                    }
                    return RedirectToAction("Index", "Profile");
                }
            }
            return View(user);

        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(TableUser user)
        {
            if (ModelState.IsValid)
            {
                user.RoleID = 2;
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View(user);
            }
        }
    }
}
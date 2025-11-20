using _23210201041___Ali_Berk_Ertemür.Context;
using _23210201041___Ali_Berk_Ertemür.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23210201041___Ali_Berk_Ertemür.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile

        private OdevContext context = new OdevContext();
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            DistrictFamousPopulationUser model = new DistrictFamousPopulationUser(context);

            return View(model);
        }
    }
}
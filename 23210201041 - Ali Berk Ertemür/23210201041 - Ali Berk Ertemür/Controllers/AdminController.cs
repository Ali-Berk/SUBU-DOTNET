using _23210201041___Ali_Berk_Ertemür.Context;
using _23210201041___Ali_Berk_Ertemür.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace _23210201041___Ali_Berk_Ertemür.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private OdevContext context = new OdevContext();

        public ActionResult Index()
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                DistrictFamousPopulationUser model = new DistrictFamousPopulationUser(context);

                return View(model);
            }

        }


        public ActionResult UpdatePopulation(int PopulationId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {


                var adminselect = context.Populations.FirstOrDefault(a => a.PopulationId == PopulationId);
                if (adminselect == null)
                {
                    return HttpNotFound();
                }

                return View(adminselect);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePopulation(TablePopulation newpopulation)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            var adminselect = context.Populations.FirstOrDefault(a => a.PopulationId == newpopulation.PopulationId);
            if (adminselect != null)
            {
                adminselect.Year = newpopulation.Year;
                adminselect.ManPopulation = newpopulation.ManPopulation;
                adminselect.WomenPopulation = newpopulation.WomenPopulation;
                adminselect.OverallPopulation = adminselect.ManPopulation + adminselect.WomenPopulation;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newpopulation);
            }
        }

        public ActionResult DeletePopulation(TablePopulation selectedPopulation)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            var selected = context.Populations.FirstOrDefault(m => m.PopulationId == selectedPopulation.PopulationId);
            if (selected != null)
            {
                context.Populations.Remove(selected);
                context.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public ActionResult CreatePopulation()
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePopulation(TablePopulation createPopulation)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            if (!ModelState.IsValid)
            {
                createPopulation.OverallPopulation = createPopulation.ManPopulation + createPopulation.WomenPopulation;
                context.Populations.Add(createPopulation);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateDistrict(int districtId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            var adminselect = context.Districts.FirstOrDefault(a => a.DistrictId == districtId);
            if (adminselect == null)
            {
                return HttpNotFound();
            }

            return View(adminselect);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateDistrict(TableDistrict newDistrict)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            var adminselect = context.Districts.FirstOrDefault(m => m.DistrictId == newDistrict.DistrictId);
            if (adminselect != null)
            {
                adminselect.DisctrictName = newDistrict.DisctrictName;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpDelete]
        public ActionResult DeleteDistrict(int districtId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.Districts.FirstOrDefault(m => m.DistrictId == districtId);
                if (adminselect != null)
                {
                    context.Districts.Remove(adminselect);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }

        }

        public ActionResult CreateDistrict()
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                return View();
            }
        }

        public ActionResult UpdateFamousPlace(int placeId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.FamousPlaces.FirstOrDefault(m => m.PlaceId == placeId);
                if (adminselect != null)
                {
                    return View(adminselect);
                }
                else
                {
                    return View();
                }
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateFamousPlace(TableFamousPlace newfamousplace)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.FamousPlaces.FirstOrDefault(m => m.PlaceId == newfamousplace.PlaceId);
                if (adminselect != null)
                {
                    adminselect.PlaceName = newfamousplace.PlaceName;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

        }

        public ActionResult DeleteFamousPlace(int placeId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.FamousPlaces.FirstOrDefault(m => m.PlaceId == placeId);
                if (adminselect != null)
                {
                    context.FamousPlaces.Remove(adminselect);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }


        }

        public ActionResult CreateFamousPlace()
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                return View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFamousPlace(TableFamousPlace famousplace)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                if (!ModelState.IsValid)
                {
                    context.FamousPlaces.Add(famousplace);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

        }

        public ActionResult UpdateSlider(int SliderId)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.Sliders.FirstOrDefault(m => m.SliderId == SliderId);
                if (adminselect != null)
                {

                    return View(adminselect);
                }
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateSlider(TableSlider Url)
        {
            if (Session["UserID"] == null || !Session["UserRole"].Equals(1))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var adminselect = context.Sliders.FirstOrDefault(m => m.SliderId == Url.SliderId);
                if (adminselect != null)
                {
                    adminselect.SliderLink = Url.SliderLink;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

        }


    }
}
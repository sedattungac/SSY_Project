using SSY_Project.Models;
using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class DashboardController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            ViewBag.order = db.Data_GecSipList.Count().ToString();
            ViewBag.product = db.Data_StokList.Count().ToString();
            ViewBag.personal = db.Data_Users.Count().ToString();
            ViewBag.customer = db.Data_CariList.Count().ToString();
            return View();
        }
        public PartialViewResult Weather()
        {

            return PartialView();
        }
        public PartialViewResult Economy()
        {

            return PartialView();
        }
        public PartialViewResult Statistic()
        {

            return PartialView();
        }
        public PartialViewResult AreaChart()
        {

            return PartialView();
        }
        public PartialViewResult DonutChart()
        {

            return PartialView();
        }
        public PartialViewResult BarChart()
        {

            return PartialView();
        }
        public PartialViewResult PieChart()
        {

            return PartialView();
        }


        public PartialViewResult Chart()
        {
            return PartialView();
        }
        public PartialViewResult Chart2()
        {
            return PartialView();
        }

        public ActionResult VisualizeResult()
        {
            return Json(categorylist(), JsonRequestBehavior.AllowGet);
        }



        public List<Chart> categorylist()
        {
            List<Chart> c = new List<Chart>();
            c.Add(new Chart()
            {
                CategoryName = "Teknoloji",
                BlogCount = 14
            });
            c.Add(new Chart()
            {
                CategoryName = "Spor",
                BlogCount = 10
            });
            c.Add(new Chart()
            {
                CategoryName = "Kitap",
                BlogCount = 16
            });
            return c;
        }


    }
}
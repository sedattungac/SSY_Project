using SSY_Project.Models;
using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class ChartController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();

        // GET: Graph
        public ActionResult Index()
        {
            return View();
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
        //Dinamik Grafik

        public List<Class2> BlogList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new DatabaseEntities())
            {
                var sedat = c.Data_StokList.Count();
                cs2 = c.Data_StokList.Select(x => new Class2
                {
                    BlogName = x.MALINCINSI,
                    Rating = 50
                }).ToList();
            }
            return cs2;
        }
        public ActionResult VisualizeResult2()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Chart1()
        {
            return View();
        }
        public ActionResult Chart2()
        {
            return View();
        }
        public ActionResult Chart3()
        {
            return View();
        }
        public ActionResult Chart4()
        {
            return View();
        }
    }
}
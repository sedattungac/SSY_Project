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
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
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

        public List<Class2> EcsCari()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new DatabaseEntities())
            {

                cs2 = c.Data_ECSCari.Select(x => new Class2
                {
                    BlogName = x.FIRMAADI,
                    Rating = (decimal)x.TUTAR
                }).ToList();
            }
            return cs2;
        }
        public ActionResult VisualizeResult2()
        {
            return Json(EcsCari(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Chart1()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }
        public List<Class2> EcsUrun()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new DatabaseEntities())
            {

                cs2 = c.Data_ECSUrunler.Select(x => new Class2
                {
                    BlogName = x.MALINCINSI,
                    Rating = (decimal)x.CIKAN
                }).ToList();
            }
            return cs2;
        }
        public ActionResult VisualizeResult3()
        {
            return Json(EcsUrun(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Chart2()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }
        public List<Class2> EcsTutar()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new DatabaseEntities())
            {

                cs2 = c.Data_ECSTutar.Select(x => new Class2
                {
                    BlogName = x.MALINCINSI,
                    Rating = (decimal)x.TUTAR
                }).ToList();
            }
            return cs2;
        }
        public ActionResult VisualizeResult4()
        {
            return Json(EcsTutar(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Chart3()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }
        public ActionResult Chart4()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class ECSController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: ECS

        //data_ecscari list
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_ECSCari.ToList();
            return View(value);
        }
        //data_ecstutar
        public ActionResult Total()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_ECSTutar.OrderByDescending(x => x.TUTAR).ToList();
            return View(value);
        }
        //data_ecsurunler
        public ActionResult Product()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_ECSUrunler.OrderByDescending(x => x.CIKAN).ToList();
            return View(value);
        }
    }
}
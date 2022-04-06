using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class PriceChangeController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: PriceChange
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_FiyatDegisen.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
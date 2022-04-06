using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class RecentArrivalsController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: RecentArrivals
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_SonGelenler.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
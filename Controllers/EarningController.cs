using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class EarningController : Controller
    {
        // GET: Earning
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();

            var personalNo = (string)Session["PERSONELNO"];
            var number = Convert.ToInt32(personalNo);
            var value = db.Data_PlasToplam.Where(x => x.PERSONELNO == number).OrderByDescending(z => z.ID).ToList();
            return View(value);
        }
    }
}
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
            var value = db.Data_ECSCari.ToList();
            return View(value);
        }
        //data_ecstutar
        public ActionResult Total()
        {
            var value = db.Data_ECSTutar.OrderByDescending(x => x.TUTAR).ToList();
            return View(value);
        }
        //data_ecsurunler
        public ActionResult Product()
        {
            var value = db.Data_ECSUrunler.OrderByDescending(x => x.SATILANMIKTAR).ToList();
            return View(value);
        }
    }
}
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
        DbDatabase db = new DbDatabase();
        // GET: ECS

        //data_ecscari list
        public ActionResult Index()
        {
            var value = db.data_ecscari.ToList();
            return View(value);
        }
        //data_ecstutar
        public ActionResult Total()
        {
            var value = db.data_ecstutar.ToList();
            return View(value);
        }
        //data_ecsurunler
        public ActionResult Product()
        {
            var value = db.data_ecsurunler.ToList();
            return View(value);
        }
    }
}
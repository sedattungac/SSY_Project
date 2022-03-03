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
        DbSahaSatisTakipEntities db = new DbSahaSatisTakipEntities();
        // GET: RecentArrivals
        public ActionResult Index()
        {
            var value = db.Data_SonGelenler.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
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
        DbDatabase db = new DbDatabase();
        // GET: RecentArrivals
        public ActionResult Index()
        {
            var value = db.data_songelenler.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
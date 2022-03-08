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
        DbDatabase db = new DbDatabase();
        // GET: PriceChange
        public ActionResult Index()
        {
            var value = db.data_fiyatdegisen.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
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
        DbSahaSatisTakipEntities db = new DbSahaSatisTakipEntities();
        // GET: PriceChange
        public ActionResult Index()
        {
            var value = db.Data_FiyatDegisen.OrderByDescending(x => x.IND).ToList();
            return View(value);
        }
    }
}
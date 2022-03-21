using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class CollectionController : Controller
    {
        // GET: Collection
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            var newCollection = db.Data_Tahsilat.OrderByDescending(x=>x.IND).ToList();
            return View(newCollection);
        }
        public ActionResult PastCollection()
        {
            var pastCollection = db.Data_GecTahsilat.ToList();
            return View(pastCollection);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class ImmobileProductController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: ImmobileProduct
        public ActionResult Index()
        {
            var value = db.Data_HareketsizUrun.ToList();
            return View(value);
        }
    }
}
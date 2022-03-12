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
        u0524050_db638Entities4 db = new u0524050_db638Entities4();
        // GET: ImmobileProduct
        public ActionResult Index()
        {
            var value = db.Data_HareketsizUrun.ToList();
            return View(value);
        }
    }
}
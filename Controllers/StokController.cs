using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class StokController : Controller
    {
        u0524050_db638Entities4 db = new u0524050_db638Entities4();
        // GET: Stok
        public ActionResult Index()
        {
            var stokList = db.Data_StokList.ToList();
            return View(stokList);
        }
    }
}
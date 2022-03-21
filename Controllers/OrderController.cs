using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            var pastOrder = db.Data_GecSipList.ToList();
            return View(pastOrder);
        }
        [HttpGet]
        public ActionResult AddOrder()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddOrder(Data_GecSipList order)
        {

            return View();
        }
    }
}
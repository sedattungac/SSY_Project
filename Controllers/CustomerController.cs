using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class CustomerController : Controller
    {

        DbSahaSatisTakipEntities db = new DbSahaSatisTakipEntities();
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = db.Data_CariList.ToList();
            return View(customerList);
        }
        public ActionResult CustomerList()
        {
            var customerList = db.Data_CariList.ToList();
            return View(customerList);
        }
        public ActionResult CustomerDetail(string id)
        { 
            var value = db.Data_CariDetay.Where(x => x.FIRMAKODU == id).ToList();
            return View(value);
        }
        public ActionResult OldBillofSale(string id)
        {
            var value = db.Data_SatFat.Where(x => x.FIRMAKODU == id).ToList();
            return View(value);
        }

    }
}
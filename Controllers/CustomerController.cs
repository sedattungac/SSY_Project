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

        DbDatabase db = new DbDatabase();
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = db.data_carilist.ToList();
            return View(customerList);
        }
        public ActionResult CustomerList()
        {
            var customerList = db.data_carilist.ToList();
            return View(customerList);
        }
        public ActionResult CustomerDetail(string id)
        { 
            var value = db.data_caridetay.Where(x => x.FIRMAKODU == id).ToList();
            return View(value);
        }
        public ActionResult OldBillofSale(string id)
        {
            var value = db.data_satfat.Where(x => x.FIRMAKODU == id).ToList();
            return View(value);
        }

    }
}
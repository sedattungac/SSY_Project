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

        DatabaseEntities db = new DatabaseEntities();
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = db.Data_CariList.ToList();
            return View(customerList);
        }
        public ActionResult CustomerInfo(string id)
        {
            var customerList = db.Data_CariBilgi.Where(x => x.IND == id).ToList();
            ViewBag.id = id;
            return View(customerList);
        }
        public ActionResult CustomerDetail(string id)
        {
            var value = db.Data_CariDetay.Where(x => x.IND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult OldBillofSale(string id)
        {
            var value = db.Data_SatFat.Where(x => x.CARIIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult OldBillofSaleDetail(string id)
        {
            var value = db.Data_SatFatDet.Where(x => x.EVRAKNO == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollection(string id)
        {
            var value = db.Data_Tahsilat.Where(x => x.FIRMANO == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollectionDetail(string id)
        {
            var value = db.Data_TahsDet.Where(x => x.BELGEIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
    }
}
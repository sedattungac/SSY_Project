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
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var customerList = db.Data_CariList.ToList();
            return View(customerList);
        }
        public ActionResult CustomerInfo(string id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var customerList = db.Data_CariBilgi.Where(x => x.IND == id).ToList();
            ViewBag.id = id;
            return View(customerList);
        }
        //public ActionResult CustomerDetail(string id)
        //{
        //    ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
        //    ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
        //    var value = db.Data_CariDetay.Where(x => x.CARIIND == id).ToList();
        //    ViewBag.id = id;
        //    return View(value);
        //}
        public ActionResult OldBillofSale(string id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_SatFat.Where(x => x.CARIIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult OldBillofSaleDetail(string id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_SatFatDet.Where(x => x.EVRAKNO == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollection(string id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_Tahsilat.Where(x => x.FIRMANO == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollectionDetail(string id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var value = db.Data_TahsDet.Where(x => x.BELGEIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
    }
}
﻿using SSY_Project.Models.Entity;
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
        public ActionResult CustomerInfo(string id)
        {
            var customerList = db.data_caribilgi.Where(x => x.IND == id).ToList();
            ViewBag.id = id;
            return View(customerList);
        }
        public ActionResult CustomerDetail(string id)
        {
            var value = db.data_caridetay.Where(x => x.IND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult OldBillofSale(string id)
        {
            var value = db.data_satfat.Where(x => x.CARIIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult OldBillofSaleDetail(string id)
        {
            var value = db.data_satfatdet.Where(x => x.CARIIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollection(string id)
        {
            var value = db.data_tahsilat.Where(x => x.FIRMANO == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
        public ActionResult LastCollectionDetail(string id)
        {
            var value = db.data_tahsdet.Where(x => x.BELGEIND == id).ToList();
            ViewBag.id = id;
            return View(value);
        }
    }
}
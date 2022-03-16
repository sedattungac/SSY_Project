﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class StokController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Stok
        public ActionResult Index()
        {
            var stokList = db.Data_StokList.ToList();
            return View(stokList);
        }
    }
}
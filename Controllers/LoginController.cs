using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SSY_Project.Models.Entity;

namespace SSY_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(Data_CariBilgi cari)
        //{
        //    DbSahaSatisTakipEntities c = new DbSahaSatisTakipEntities();
        //    var admininfo = c.Data_CariBilgi.FirstOrDefault(x => x.YETKILI == cari.YETKILI
        //      && x.SIFRE == p.SIFRE);
        //    if (admininfo != null)
        //    {
        //        FormsAuthentication.SetAuthCookie(admininfo.EMAIL, false);
        //        Session["EMAIL"] = admininfo.EMAIL.ToString();
        //        return RedirectToAction("Welcome", "Login");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Login");
        //    }

        //}
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
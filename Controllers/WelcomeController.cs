using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            var mail = (string)Session["EMail"];
            var degerler = db.Data_Users.Where(x => x.EMAIL == mail).ToList();
            ViewBag.m = mail;
            var adminad = db.Data_Users.Where(x => x.EMAIL == mail).Select(y => y.USERNAME).FirstOrDefault();
            ViewBag.adminad = adminad;
            var adminmail = db.Data_Users.Where(x => x.EMAIL == mail).Select(y => y.EMAIL).FirstOrDefault();
            ViewBag.adminmail = adminmail;
            var firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.firma = firma;
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View(degerler);
        }
    }
}
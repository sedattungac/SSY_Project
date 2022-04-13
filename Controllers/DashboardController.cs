using PagedList;
using SSY_Project.Models;
using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class DashboardController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            ViewBag.order = db.Data_GecSipList.Count().ToString();
            ViewBag.product = db.Data_StokList.Count().ToString();
            ViewBag.personal = db.Data_Users.Count().ToString();
            ViewBag.customer = db.Data_CariList.Count().ToString();
            return View();
        }
        public PartialViewResult Weather()
        {

            return PartialView();
        }
        public PartialViewResult Economy()
        {

            return PartialView();
        }
        public PartialViewResult Statistic()
        {

            return PartialView();
        }
        public PartialViewResult EcsUrunler(int sayfa = 1)
        {
            var list = db.Data_ECSUrunler.ToList().ToPagedList(sayfa, 5);
            return PartialView(list);
        }
        public PartialViewResult EcsCari(int sayfa=1)
        {
            var list = db.Data_ECSCari.ToList().ToPagedList(sayfa,5);
            return PartialView(list);
        }
        public PartialViewResult EcsTutar(int sayfa = 1)
        {
            var list = db.Data_ECSTutar.ToList().ToPagedList(sayfa, 5);
            return PartialView(list);
        }

    }
}
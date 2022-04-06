using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class AnnunciationController : Controller
    {
        // GET: Annunciation
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var degerler = db.Data_Duyurular.OrderByDescending(x => x.TARIH).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddAnnunciation()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult AddAnnunciation(Data_Duyurular m)
        {
            var mail = (string)Session["USERNAME"];
            m.TARIH = DateTime.Now;
            m.GONDEREN = mail;
            db.Data_Duyurular.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var ktg = db.Data_Duyurular.Find(id);
            db.Data_Duyurular.Remove(ktg);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult EditAnnunciation(int id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var degerler = db.Data_Duyurular.Find(id);
            return View("EditAnnunciation", degerler);
        }
        [HttpPost]
        public ActionResult EditAnnunciation(Data_Duyurular p)
        {
            var degerler = db.Data_Duyurular.Find(p.ID);
            degerler.ICERIK = p.ICERIK;
            degerler.KONU = p.KONU;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
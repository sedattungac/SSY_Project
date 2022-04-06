using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DatabaseEntities db = new DatabaseEntities();
        // GET: Mesaj

        public ActionResult Inbox()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var mail = (string)Session["EMAIL"];
            var message = db.Data_Mesajlar.Where(x => x.ALICI == mail && x.DURUM == true).OrderByDescending(x => x.ID).ToList();
            var sentMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.GONDEREN == mail).ToString();
            ViewBag.d2 = sentMessageCount;
            var incomingMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.ALICI == mail).ToString();
            ViewBag.d1 = incomingMessageCount;
            var garbageCount = db.Data_Mesajlar.Where(x => x.DURUM == false).Count(x => x.DURUM == false).ToString();
            ViewBag.d3 = garbageCount;
            return View(message);
        }

        public ActionResult SentMessage()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var mail = (string)Session["EMAIL"];
            var message = db.Data_Mesajlar.Where(x => x.GONDEREN == mail && x.DURUM == true).OrderByDescending(z => z.ID).ToList();
            var sentMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.GONDEREN == mail).ToString();
            ViewBag.d2 = sentMessageCount;
            var incomingMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.ALICI == mail).ToString();
            ViewBag.d1 = incomingMessageCount;
            var garbageCount = db.Data_Mesajlar.Where(x => x.DURUM == false).Count(x => x.DURUM == false).ToString();
            ViewBag.d3 = garbageCount;
            return View(message);
        }

        public ActionResult MessageDetail(int id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();

            var message = db.Data_Mesajlar.Where(x => x.ID == id).ToList();

            var mail = (string)Session["EMAIL"];
            var sentMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.GONDEREN == mail).ToString();
            ViewBag.d2 = sentMessageCount;
            var incomingMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.ALICI == mail).ToString();
            ViewBag.d1 = incomingMessageCount;
            var garbageCount = db.Data_Mesajlar.Where(x => x.DURUM == false).Count(x => x.DURUM == false).ToString();
            ViewBag.d3 = garbageCount;
            return View(message);
        }

        [HttpGet]
        public ActionResult AddMessage()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var mail = (string)Session["EMAIL"];
            var sentMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.GONDEREN == mail).ToString();
            ViewBag.d2 = sentMessageCount;
            var incomingMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.ALICI == mail).ToString();
            ViewBag.d1 = incomingMessageCount;
            var garbageCount = db.Data_Mesajlar.Where(x => x.DURUM == false).Count(x => x.DURUM == false).ToString();
            ViewBag.d3 = garbageCount;
            return View();
        }

        [HttpPost]
        public ActionResult AddMessage(Data_Mesajlar m)
        {
          
            var mail = (string)Session["EMAIL"];
            m.TARIH = DateTime.Now;
            m.GONDEREN = mail;
            m.DURUM = true;
            db.Data_Mesajlar.Add(m);
            db.SaveChanges();
            return RedirectToAction("SentMessage");
        }
        public ActionResult Recycle()
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var mail = (string)Session["EMAIL"];
            var message = db.Data_Mesajlar.Where(x => x.DURUM == false).ToList();
            var sentMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.GONDEREN == mail).ToString();
            ViewBag.d2 = sentMessageCount;
            var incomingMessageCount = db.Data_Mesajlar.Where(x => x.DURUM == true).Count(x => x.ALICI == mail).ToString();
            ViewBag.d1 = incomingMessageCount;
            var garbageCount = db.Data_Mesajlar.Where(x => x.DURUM == false).Count(x => x.DURUM == false).ToString();
            ViewBag.d3 = garbageCount;
            return View(message);
        }
        public ActionResult Garbage(int id)
        {
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            var hesap = db.Data_Mesajlar.ToList().Find(x => x.ID == id);
            hesap.DURUM = false;
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public ActionResult Delete(int id)
        {
            var ktg = db.Data_Mesajlar.Find(id);
            db.Data_Mesajlar.Remove(ktg);
            db.SaveChanges();
            return RedirectToAction("Recycle");

        }
    }
}
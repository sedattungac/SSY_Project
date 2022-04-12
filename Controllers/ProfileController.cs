using SSY_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            var mail = (string)Session["EMAIL"];
            ViewBag.image = db.Data_Users.Where(x => x.EMAIL == mail).Select(y => y.FOTO_URL).FirstOrDefault();
            ViewBag.firma = db.Data_Firma.Select(y => y.FIRMAADI).FirstOrDefault();
            ViewBag.logo = db.Data_Firma.Select(x => x.LOGO).FirstOrDefault();
            return View();
        }
        [HttpGet]
        public PartialViewResult Edit()
        {

            var mail = (string)Session["EMAIL"];
            var id = db.Data_Users.Where(x => x.EMAIL == mail).Select(y => y.ID).FirstOrDefault();
            var findUser = db.Data_Users.Find(id);
            return PartialView("Edit", findUser);

        }
        [HttpPost]
        public ActionResult EditProfile(Data_Users p, HttpPostedFileBase UrunGorsel)
        {
            var urn = db.Data_Users.Find(p.ID);
            urn.EMAIL = p.EMAIL;
            urn.PASSWORD = p.PASSWORD;
            urn.USERNAME = p.USERNAME;
            //urn.FOTO_URL = p.FOTO_URL;
            if (ModelState.IsValid)
            {
                if (UrunGorsel != null)
                {
                    string dosyaadi = Path.GetFileName(UrunGorsel.FileName);
                    string yol = "/Image/" + dosyaadi;
                    UrunGorsel.SaveAs(Server.MapPath(yol));
                    urn.FOTO_URL = yol;
                }
            }
            db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
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
            ViewBag.image= db.Data_Users.Where(x => x.EMAIL == mail).Select(y => y.FOTO_URL).FirstOrDefault();
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
        public ActionResult Edit(Data_Users user, HttpPostedFileBase ImageUrl)
        {
            var userId = db.Data_Users.Find(user.ID);


            if (ModelState.IsValid)
            {
                userId.EMAIL = user.EMAIL;
                userId.GSM = user.GSM;
                userId.PASSWORD = user.PASSWORD;
                userId.USERNAME = user.USERNAME;
                if (ImageUrl != null)
                {
                    string dosyaadi = Path.GetFileName(ImageUrl.FileName);
                    string yol = "/Image/" + dosyaadi;
                    ImageUrl.SaveAs(Server.MapPath(yol));
                    userId.FOTO_URL = yol;
                }

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
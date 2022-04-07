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
        DatabaseEntities db = new DatabaseEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Data_Users cari)
        {

            var admininfo = db.Data_Users.FirstOrDefault(x => x.EMAIL == cari.EMAIL
              && x.PASSWORD == cari.PASSWORD);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.EMAIL, false);
                Session["EMAIL"] = admininfo.EMAIL.ToString();
                Session["USERNAME"] = admininfo.USERNAME.ToString();
                Session["FOTOURL"] = admininfo.FOTO_URL.ToString();

                return RedirectToAction("Index", "Welcome");
            }
            else
            {
                ViewBag.alert = "Mail ya da parolanız hatalı!";
                return View("Index");
            }

        }
       
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
//using SSY_Project.Models;
//using SSY_Project.Models.Entity;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace SSY_Project.Controllers
//{
//    public class ChartController : Controller
//    {
//        DatabaseEntities db = new DatabaseEntities();

//        // GET: Graph
//        public ActionResult Index()
//        {
//            return View();
//        }
//        //Dinamik Grafik
//        public ActionResult VisualizeResult2()
//        {
//            return Json(BlogList(), JsonRequestBehavior.AllowGet);
//        }
//        public List<Chart> BlogList()
//        {
//            List<Chart> cs2 = new List<Chart>();
//            using (var c = new DatabaseEntities())
//            {
//                cs2 = c.Data_ECSUrunler.Select(x => new Chart
//                {
//                    ProductName = x.MALINCINSI,
//                    Rating =x.IND
//                });.ToList();
//            }
//            return cs2;
//        }
//    }
//}
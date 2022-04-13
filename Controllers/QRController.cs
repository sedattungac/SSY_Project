using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSY_Project.Controllers
{
    public class QRController : Controller
    {
        // GET: QR
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


    }
}
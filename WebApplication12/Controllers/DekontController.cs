using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;
namespace WebApplication12.Controllers
{
    public class DekontController : Controller
    {
        // GET: Dekont
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult DekontListele()
        {
            var deger = db.DekontListele.ToList();
            return View(deger);
        }
        public ActionResult YoneticiDekontListele()
        {
            var deger = db.DekontListele.ToList();
            return View(deger);
        }
    }
}
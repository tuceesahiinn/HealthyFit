using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    public class FaturaController : Controller
    {
        // GET: Fatura
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult FaturaEkleme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FaturaEkleme(short SalonId,short MusteriId, decimal Miktar,DateTime Tarih)
        {
            db.FaturaEkleme(SalonId, MusteriId, Miktar, Tarih);
            db.SaveChanges();
            return View();
        }
        public ActionResult MusteriFaturaListeleme()
        {
            var deger = db.Fatura.ToList();
            return View(deger);
        }
        public ActionResult FaturaListele()
        {
            var deger = db.FaturaListele.ToList();
            return View(deger);
        }
    }
}
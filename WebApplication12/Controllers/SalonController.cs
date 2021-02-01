using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    public class SalonController : Controller
    {
        // GET: Salon
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult SalonKurslarıListele() 
        {

            List<String> isim = (from s in db.Salon
                      join sa in db.SalonKurslariListele on s.SalonId equals sa.SalonId
                      select s.SalonAd).ToList();
            List<String> kursAdi = (from s in db.Kurs
                        join sa in db.SalonKurslariListele on s.KursId equals sa.KursId
                        select s.KursAd).ToList();


            ViewBag.Ad = isim;
            ViewBag.KursAd = kursAdi;
            return View();
        }
        public ActionResult SalonListele()
        {
            var deger = db.SalonListele.ToList();
            return View(deger);
        }
    }
}
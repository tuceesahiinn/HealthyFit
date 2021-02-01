using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;
namespace WebApplication12.Controllers
{
    public class RandevuController : Controller
    {
        // GET: Antrenor
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult RandevuListele()
        {
            var deger = db.Randevu.ToList();
            
            return View(deger);
        }
        public ActionResult RandevuSil(int id)
        {
            var rand = db.Randevu.Find(id);
            db.Randevu.Remove(rand);
            db.SaveChanges();
            return RedirectToAction("RandevuListele");
        }
        public ActionResult RandevuGetir(int id)
        {
            var rand = db.Randevu.Find(id);
            return View("RandevuGetir", rand);
        }
        public ActionResult RandevuGuncelle(Randevu r)
        {
            var rand = db.Randevu.Find(r.RandevuId);
            rand.SalonId = r.SalonId;
            rand.PersonelId = r.PersonelId;
            rand.PersonelTuru = r.PersonelTuru;
            rand.MusteriId = r.MusteriId;
            rand.TarihSaat = r.TarihSaat;
            db.SaveChanges();
            return RedirectToAction("RandevuListele");
        }


        [HttpGet]
        public ActionResult AntrenorRandevuAl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AntrenorRandevuAl(short SalonId,short PersonelId,short MusteriId,DateTime TarihSaat)
        {
            db.AntrenorRandevuAl(SalonId, PersonelId, MusteriId, TarihSaat);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult DiyetisyenRandevuAl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DiyetisyenRandevuAl(short SalonId, short PersonelId, short MusteriId, DateTime TarihSaat)
        {
            db.DiyetisyenRandevuAl(SalonId, PersonelId, MusteriId, TarihSaat);
            db.SaveChanges();
            return View();
        }
        public ActionResult PersonelRandevuListele()
        {
            var deger=db.Randevu.ToList();
            return View(deger);
        }
    }
}
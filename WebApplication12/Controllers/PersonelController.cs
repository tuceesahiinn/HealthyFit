using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    public class PersonelController : Controller
    {

        // GET: Egitmen
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelEkle(long TC, string KullaniciAd, string Sifre, string Ad,string Soyad,short SalonId,long IBAN, long SGKNo,bool PersonelTur)
        {

            db.PersonelKullaniciKayitlama(TC, KullaniciAd, Sifre, Ad, Soyad, SalonId,IBAN,SGKNo,PersonelTur);
            db.SaveChanges();
            return View();
        }
        public ActionResult PersonelListele()
        {
            var deger=db.PersonelList.ToList();
            return View(deger);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    [AllowAnonymous]
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Login l)
        {
            var bilgiler = db.Login.FirstOrDefault(x => x.KullaniciAd == l.KullaniciAd && x.Sifre == l.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAd, false);
                Session["KullaniciAd"] = bilgiler.KullaniciAd.ToString();
                if (User.IsInRole("False"))
                {                  
                    return RedirectToAction("AntrenorRandevuAl", "Randevu");
                }
                else 
                {               
                    return RedirectToAction("PersonelRandevuListele", "Randevu");
                }         
            }
            else
            {
                return View();
            }
        }
        public ActionResult YoneticiGirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YoneticiGirisYap(Login l)
        {
            var bilgiler = db.Login.FirstOrDefault(x => x.KullaniciAd == l.KullaniciAd && x.Sifre == l.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAd, false);
                Session["KullaniciAd"] = bilgiler.KullaniciAd.ToString();
                return RedirectToAction("PersonelListele", "Personel");
            }
            else
            {
                return View();
            }
        }
    }
}
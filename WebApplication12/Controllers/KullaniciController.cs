using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult BilgiListele()
        {
            var deger= db.Musteri.ToList();
            return View(deger);
        }
    }
}
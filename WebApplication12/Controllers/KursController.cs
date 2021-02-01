using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;
namespace WebApplication12.Controllers
{
    public class KursController : Controller
    {
        // GET: Egitim
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult KursEkleme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KursEkleme(string KursAd)
        {
            db.YoneticiKursEkleme(KursAd);
            db.SaveChanges();
            return View();
        }
       
    }
}
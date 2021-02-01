using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    [AllowAnonymous]
    public class KayitOlController : Controller
    {
        // GET: KayitOl
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayitOl(Login l)
        {
            if (!ModelState.IsValid)
            {
                return View("KayitOl");
            }
            db.Login.Add(l);
            db.SaveChanges();
            return View();
        }
    }
}
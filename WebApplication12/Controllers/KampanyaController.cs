using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    [AllowAnonymous]
    public class KampanyaController : Controller
    {
        // GET: Kampanya
        public ActionResult Index()
        {
            return View();
        }
    }
}
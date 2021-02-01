﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication12.Controllers
{
    public class CikisYapController : Controller
    {
        // GET: CikisYap
        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "GirisYap");
        }
    }
}
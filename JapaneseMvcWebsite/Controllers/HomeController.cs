﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JapaneseMvcWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Main/
        public ActionResult Index()
        {
            return View();
        }
    }
}
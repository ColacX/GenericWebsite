﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IISApp.Areas.Test.Controllers
{
    public class TestController : Controller
    {
        // GET: Test/Test
        public ActionResult Index()
        {
            return View();
        }
    }
}
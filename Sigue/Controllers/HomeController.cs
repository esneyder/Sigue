﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigue.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles="Estudiante")]
        public ActionResult Estudiante()
        {
            return View();
        }
          [Authorize(Roles = "Asesores")]
          public ActionResult Asesores()
        {
            return View();
        }
          [Authorize(Roles = "Empresas")]
        public ActionResult Empresas()
        {
            return View();
        }
        [Authorize]
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
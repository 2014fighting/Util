﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Util.Samples.Webs.Models;

namespace Util.Samples.Webs.Controllers {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.username = "vicky";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Vicky()
        {
            return View();
        }
    }
}

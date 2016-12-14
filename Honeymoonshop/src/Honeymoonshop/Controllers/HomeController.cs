﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Honeymoonshop.Data;
using Microsoft.AspNetCore.Mvc;

namespace Honeymoonshop.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext Context;

        public HomeController(ApplicationDbContext context)
        {
            this.Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Catalogus()
        {
            return View();
        }

    }
}

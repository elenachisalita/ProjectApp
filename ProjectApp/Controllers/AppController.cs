﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            throw new InvalidOperationException();
            return View();
        }
    }
}
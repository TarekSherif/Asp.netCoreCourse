﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class EmptyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
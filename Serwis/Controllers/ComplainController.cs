﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Serwis.Controllers
{
    public class ComplainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
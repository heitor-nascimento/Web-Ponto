﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPonto.Controllers
{
    public class PontoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

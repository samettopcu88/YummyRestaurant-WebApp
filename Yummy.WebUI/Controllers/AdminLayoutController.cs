﻿using Microsoft.AspNetCore.Mvc;

namespace Yummy.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

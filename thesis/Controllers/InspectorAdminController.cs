﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace thesis.Controllers
{
    public class InspectorAdminController : Controller
    {
        [Authorize(Policy = "RequireInspectorAdmin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
    }
}

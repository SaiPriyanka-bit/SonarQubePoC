using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
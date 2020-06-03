using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;
using System.Buffers;
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
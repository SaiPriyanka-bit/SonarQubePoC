using System;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreDemo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
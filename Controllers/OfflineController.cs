using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Collections;
using System.Configuration;
namespace ASP.NETCoreDemo.Controllers
{
    public class OfflineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
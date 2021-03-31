using System;
using Microsoft.AspNetCore.Mvc;

namespace LearningSeriLog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using FriendsCafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FriendsCafe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}

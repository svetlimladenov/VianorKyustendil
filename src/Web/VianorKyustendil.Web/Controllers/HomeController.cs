using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VianorKyustendil.Data.Core;
using VianorKyustendil.Data.Models;
using VianorKyustendil.Web.Models;

namespace VianorKyustendil.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<VianorKyustendilUser> userRepository;

        public HomeController(IRepository<VianorKyustendilUser> userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var usersCount = userRepository.All().Count();
            ViewData["UsersCount"] = $"This app has {usersCount}";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

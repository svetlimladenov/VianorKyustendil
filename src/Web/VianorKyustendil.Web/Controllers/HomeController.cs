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
    public class HomeController : BaseController
    {
        private readonly IRepository<VianorKyustendilUser> userRepository;
        private readonly IRepository<Product> productsRepository;

        public HomeController(IRepository<VianorKyustendilUser> userRepository, IRepository<Product> productsRepository)
        {
            this.userRepository = userRepository;
            this.productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            var usersCount = userRepository.All().Count();
            ViewData["UsersCount"] = $"This app has {usersCount} users";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.ProductsCount = this.productsRepository.All().Count();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

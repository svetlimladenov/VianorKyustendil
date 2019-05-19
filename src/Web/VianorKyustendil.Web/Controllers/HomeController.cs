using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using VianorKyustendil.Data.Core;
using VianorKyustendil.Data.Models;
using VianorKyustendil.Web.Areas.Identity.Pages.Account;
using VianorKyustendil.Web.Models;

namespace VianorKyustendil.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IRepository<VianorKyustendilUser> userRepository;
        private readonly IRepository<Product> productsRepository;
        private readonly IConfiguration configuration;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(
            IRepository<VianorKyustendilUser> userRepository,
            IRepository<Product> productsRepository, 
            IConfiguration configuration,
            IHostingEnvironment hostingEnvironment)
        {
            this.userRepository = userRepository;
            this.productsRepository = productsRepository;
            this.configuration = configuration;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var usersCount = userRepository.All().Count();
            ViewData["UsersCount"] = $"This app has {usersCount} users";
            ViewData["Hi"] = this.configuration["Greeting"];
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.ProductsCount = this.productsRepository.All().Count();
            return View();
        }

        public IActionResult Membership()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

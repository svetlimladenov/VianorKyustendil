using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VianorKyustendil.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class ArticlesController : AdministrationBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string username)
        {
            return this.Content(username);
        }
    }
}
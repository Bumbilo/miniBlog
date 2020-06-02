using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniBlog.Models;

namespace MiniBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(ArticleRepositoryModel.GetArticles);
        }

        public IActionResult News()
        {
            return View(ArticleRepositoryModel.GetArticles);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(FBFormModel form)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Article(int Id)
        {
            return View(ArticleRepositoryModel.GetArticles.Where(r => r.Id == Id));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

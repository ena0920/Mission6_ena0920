using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_ena0920.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ena0920.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieCollectionContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieCollectionContext movieContext)
        {
            _logger = logger;
            _movieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]

        public IActionResult EnterMovie(ApplicationResponse response)
        {
            _movieContext.Add(response);
            _movieContext.SaveChanges();
            return View("Confirmation", response);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

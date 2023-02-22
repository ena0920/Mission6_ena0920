using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieCollectionContext _movieContext { get; set; }

        public HomeController(MovieCollectionContext movieContext)
        {
            _movieContext = movieContext;
        }

        public IActionResult Index()
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
            ViewBag.Category = _movieContext.Category.ToList();
       
            return View();
        }

        [HttpPost]

        public IActionResult EnterMovie(ApplicationResponse response)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(response);
                _movieContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }

        }

        public IActionResult MovieList()
        {
            var movies = _movieContext.responses.Include(item => item.Category)
                .OrderBy(item => item.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int applicationID)
        {
            ViewBag.Category = _movieContext.Category.ToList();

            var movies = _movieContext.responses.Single(item=>item.ApplicationID == applicationID);
            return View("EnterMovie", movies);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            _movieContext.Update(ar);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int applicationID)
        {
            var application = _movieContext.responses.Single(item => item.ApplicationID == applicationID);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _movieContext.responses.Remove(ar);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}

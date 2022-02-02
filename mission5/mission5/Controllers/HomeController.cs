using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission4.Models;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Create the context object
        private MovieFormContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieFormContext mfc)
        {
            _logger = logger;
            _movieContext = mfc;
        }

        // Index page view
        public IActionResult Index()
        {
            return View();
        }

        // Get the blank movie form
        [HttpGet]
        public IActionResult MovieForm()
        {
            // Get a list of categories for the dropdown
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieForm mf)
        {
            // Return page if invalid form
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View();
            }

            // Save the movie to the DB
            _movieContext.Add(mf);
            _movieContext.SaveChanges();

            return View("Confirmation", mf);
        }

        // Get the movie list
        [HttpGet]
        public IActionResult MovieList()
        {
            // Get a list of movies and order them by Title
            var movies = _movieContext.Responses
                    .Include(x => x.Category)
                    .OrderBy(x => x.Title)
                    .ToList();

            return View(movies);
        }

        // Edit a movie
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            // Fill the form with the movie data
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieForm mf)
        {
            // Save the new data
            _movieContext.Update(mf);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        // Delete a movie
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieForm mf)
        {
            // Delete from DB
            _movieContext.Responses.Remove(mf);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
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

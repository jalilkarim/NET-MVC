using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
               // new Customer {Name = "Customer 1"},
                //new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
               Movie = movie,
               Customers = customers
            };

            return View(viewModel);
            //return Content("Chupame la pija");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        // GET: Movies/Edit?id=3
        public ActionResult Edit(int id)
        {

            return Content("Id = " + id);
        }

        // GET: Movies
        public ViewResult Index() // int parameter has "?" to make it nullable (optional parameter)
        {
            /*
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            */
            var allMovies = new Movie();
            allMovies.Id = 1;
            allMovies.Name = "All Movies";

            /*
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Avatar"}
            };
            */
            return View(allMovies);
        }


        [Route("movies/released/{year:regex(\\d{4}):range(1900,2100)}/{month:regex(\\d{2}):range(1,12)}")] // This is added to specify the attribute route using the optimal way which is MVC
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content (year + "/" + month);
        }

        public ActionResult MovieCatalog()
        {
            var movieCatalog = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Avatar"},
                new Movie {Id = 3, Name = "Paw Patrol"},
                new Movie {Id = 4, Name = "Moana"},
                new Movie {Id = 5, Name = "Frozen"}
            };
            return View(movieCatalog.ToList());
        }
    }
}
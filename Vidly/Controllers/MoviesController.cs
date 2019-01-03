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
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
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
        public ActionResult Index(int? pageIndex, string sortBy) // int parameter has "?" to make it nullable (optional parameter)
        { 
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        [Route("movies/released/{year:regex(\\d{4}):range(1900,2100)}/{month:regex(\\d{2}):range(1,12)}")] // This is added to specify the attribute route using the optimal way which is MVC
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content (year + "/" + month);
        }
    }
}
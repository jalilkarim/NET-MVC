using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
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

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content (year + "/" + month);
        }
    }
}
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
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie1 = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Rhea"},
                new Customer { Name = "Molly"}
            };

            var viewModel = new ViewModels.RandomMovieViewModel()
            {
                movie = movie1,
                Customers = customers
            };

            return View(viewModel);

            //Other possibilities
            //return Content("Hello! My name is Lily. (I dont want to use my real name) ");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy = "n" });
     
        }

        [Route("movies/released/{year}/{month:range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content ("Year: " + year + "; Month: " + month);
        }
        
    }
}
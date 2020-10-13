using Microsoft.Ajax.Utilities;
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
            var movie = new Movie() { name = "Avengers" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel    
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        // GET: movies/released/year/month
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        // GET: Movies/Random
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
        /*
        // GET: Movies/Edit
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }// GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
        */
    }
}
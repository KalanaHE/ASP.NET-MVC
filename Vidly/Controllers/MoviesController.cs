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
            var movie = new Movie() { Name = "Shrek" };
            //return View(movie);
            return RedirectToAction("Index", "Home", new{page=1,sortby="date"});
        }

        public ActionResult Edit(int id)
        {
            return Content("ID = " + id);
        }

        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("Page Index = {0} and Sort By = {1}", pageIndex, sortBy)); 
        }
    }
}
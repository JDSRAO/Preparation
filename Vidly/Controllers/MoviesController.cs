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
        static List<Movie> movies = new List<Movie>()
        {
            new Movie() { ID = 1, Name = "X-Men : Origins" },
            new Movie() { ID = 2, Name = "Wolverine" }
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }
    }
}
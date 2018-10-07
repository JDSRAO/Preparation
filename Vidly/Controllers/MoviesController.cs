using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Identity;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : Controller
    {
        private AuthContext context = new AuthContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = context.Movies.Include(x => x.Genre).ToList();
            return View(movies);
        }

        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = context.Movies.FirstOrDefault(x => x.ID == id);
            if(movie == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movie);
            }
        }
    }
}
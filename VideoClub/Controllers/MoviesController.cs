using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoClub.ViewModels;
using VideoClub.Models;
using System;

namespace VideoClub.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext DbContex;
        // GET: Movies
        public MoviesController()
        {
            DbContex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            DbContex.Dispose();
        }


        public ActionResult New()
        {
            var gener = DbContex.gender.ToList();
            var viewModel = new MovieFormViewModel
            {
                Gender = gener
            };
            return View("MovieForm", viewModel);
        }
        public ViewResult Index()
        {
            //var movies = GetMovies();
            var movies = DbContex.Movies.Include(c => c.Gender).ToList();

            return View(movies);    
        }
        public ActionResult Edit(int id)
        {
            var movie = DbContex.Movies.SingleOrDefault(c => c.Id == id);
            if(movie == null)

            return HttpNotFound();
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Gender = DbContex.gender.ToList()
            };
            return View("MovieForm", viewModel);
        }


        public ActionResult Details(int id)
        {
            var movie = DbContex.Movies.Include(c => c.Gender).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                DbContex.Movies.Add(movie);

            }
            else
            {
                var movieInDb = DbContex.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenderId = movie.GenderId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movie.ReleaseDate = movie.ReleaseDate;
            }
            DbContex.SaveChanges();
            return RedirectToAction("Index","Movies");
        }

        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie { Id = 1, Name = "Shrek" },
        //        new Movie { Id = 2, Name = "Wall-e" }
        //    };
        //}

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}

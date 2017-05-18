using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoClub.ViewModels;
using VideoClub.Models;

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


        public ViewResult Index()
        {
            //var movies = GetMovies();
            var movies = DbContex.Movies.Include(c => c.Gender).ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = DbContex.Movies.Include(c => c.Gender).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
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

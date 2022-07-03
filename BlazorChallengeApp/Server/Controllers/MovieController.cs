using BlazorChallengeApp.Server.DatabaseContext;
using BlazorChallengeApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorChallengeApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        
        private MovieDbContext _dbContext;
        public MovieController(MovieDbContext movieDbContext)
        {
            _dbContext = movieDbContext;
        }

        // GET: MovieController
        [HttpGet]
        public List<Movie> IndexAsync()
        {
            var output = new List<Movie>();
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            output =  (from M in _dbContext.Movie
                         join R in _dbContext.RunningTimes
                         on M.RunningTimes.Id equals R.Id
                         select new Movie{
                             Id  = M.Id,
                             Title = M.Title,
                             Director = M.Director,
                             Cast = M.Cast,
                             Genre = M.Genre,
                             Notes = M.Notes,
                             Year = M.Year,
                             RunningTimes  = R,
                         }).ToList();

            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            return output;
        }

        // POST: MovieController/All
        [HttpPost]
        public ActionResult Create(List<Movie> movies)
        {

            try
            {
                _dbContext.Movie.AddRange(movies.Where(x => !_dbContext.Movie.Any(y => y.Id == x.Id)));
                _dbContext.SaveChanges();
                return Ok();
            }
            catch
            {
                return NotFound("Can't save Movies...");
            }
        }
        
        /*        // GET: MovieController/Details/5
                public ActionResult Details(int id)
                {
                    return View();
                }

                // GET: MovieController/Create
                public ActionResult Create()
                {
                    return View();
                }

                // POST: MovieController/Create
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Create(IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }

                        [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Create(IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }
                // GET: MovieController/Edit/5
                public ActionResult Edit(int id)
                {
                    return View();
                }

                // POST: MovieController/Edit/5
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Edit(int id, IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }

                // GET: MovieController/Delete/5
                public ActionResult Delete(int id)
                {
                    return View();
                }

                // POST: MovieController/Delete/5
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Delete(int id, IFormCollection collection)
                {
                    try
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }*/
    }
}

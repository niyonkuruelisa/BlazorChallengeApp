using BlazorChallengeApp.Server.CQRS.Queries.Movie;
using BlazorChallengeApp.Server.DatabaseContext;
using BlazorChallengeApp.Shared;
using MediatR;
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
        private IMediator mediator;
        public MovieController(MovieDbContext movieDbContext,IMediator mediator)
        {
            _dbContext = movieDbContext;
            this.mediator = mediator;
        }

        // GET: MovieController
        [HttpGet]
        public async Task<List<Movie>> IndexAsync()
        {
            var response = await mediator.Send(new GetAllMovies.Query());

            return response.Movies;
        }

        // POST: MovieController/Create
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
        // GET: MovieController/Details/5
        [HttpGet("Details/{movieId}")]
        public async Task<ActionResult> Details(int movieId)
        {
            
            try
            {
                var response = await mediator.Send(new GetMovieById.Query(movieId));
                var movie = response.Movie;
                return Ok(movie);
            }
            catch (Exception e)
            {

                return NotFound("error: " + e.Message);
            }

        }
    }
}

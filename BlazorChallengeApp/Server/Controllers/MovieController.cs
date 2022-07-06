using BlazorChallengeApp.Server.CQRS.Commands.Movie;
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
        private IMediator mediator;
        public MovieController(IMediator mediator)
        {
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
        public async Task<ActionResult> Create(List<Movie> movies)
        {

            try
            {
                var response = await mediator.Send(new CreateMovies.Command(movies));

                return Ok(response.saved);
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

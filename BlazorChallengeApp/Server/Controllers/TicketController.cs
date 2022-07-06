using BlazorChallengeApp.Server.DatabaseContext;
using BlazorChallengeApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChallengeApp.Server.Controllers
{
    public class TicketController
    {
        private MovieDbContext _dbContext;
        public TicketController(MovieDbContext movieDbContext)
        {
            _dbContext = movieDbContext;
        }

        // GET: TicketController
        [HttpGet("All")]
        public List<Ticket> Index()
        {
            var output = new List<Ticket>();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            output = (from T in _dbContext.Ticket
                      select T).ToList();

#pragma warning restore CS8602 // Dereference of a possibly null reference.
            return output;
        }
    }
}

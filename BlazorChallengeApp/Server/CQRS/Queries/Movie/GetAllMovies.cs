using BlazorChallengeApp.Server.DatabaseContext;
using BlazorChallengeApp.Shared;
using MediatR;

namespace BlazorChallengeApp.Server.CQRS.Queries.Movie
{
    public static class GetAllMovies
    {
        // Data to execute
        public record Query() : IRequest<Response>;

        // Handler
        public class Handler : IRequestHandler<Query, Response>
        {

            MovieDbContext movieDbContext;
            public Handler(MovieDbContext movieDbContext)
            {
                this.movieDbContext = movieDbContext;
            }

            public async Task<Response>? Handle(Query request, CancellationToken cancellationToken)
            {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var output = (from M in movieDbContext.Movie
                              join R in movieDbContext.RunningTimes
                              on M.RunningTimes.Id equals R.Id
                              select new Shared.Movie
                              {
                                  Id = M.Id,
                                  Title = M.Title,
                                  Director = M.Director,
                                  Cast = M.Cast,
                                  Genre = M.Genre,
                                  Notes = M.Notes,
                                  Year = M.Year,
                                  RunningTimes = R,
                              }).ToList();

                return new Response(output) ?? null;

#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        /// <summary>
        /// Reponse data
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Title"></param>
        /// <param name="Director"></param>
        /// <param name="Cast"></param>
        /// <param name="Genre"></param>
        /// <param name="Notes"></param>
        /// <param name="Year"></param>
        /// <param name="RunningTimes"></param>
        
        public record Response(List<Shared.Movie> Movies);
    }
}


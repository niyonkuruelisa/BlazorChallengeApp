using BlazorChallengeApp.Server.DatabaseContext;
using MediatR;

namespace BlazorChallengeApp.Server.CQRS.Commands.Movie
{
    public static class CreateMovies
    {
        /// <summary>
        ///Data to execute
        /// </summary>
        public record Command(List<Shared.Movie> Movies) : IRequest<Response>;

        public class Handler : IRequestHandler<Command, Response>
        {
            MovieDbContext _movieDbContext;
            public Handler(MovieDbContext movieDbContext)
            {
                this._movieDbContext = movieDbContext;
            }

            /// <summary>
            /// Handle All business logic. Get Movie And It's assiated Days And Time.
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                _movieDbContext.Movie.AddRange(request.Movies.Where(x => !_movieDbContext.Movie.Any(y => y.Id == x.Id)));
                _movieDbContext.SaveChanges();
                return new Response(true);
            }
        }
        /// <summary>
        /// Return true
        /// </summary>
        /// <param name="saved"></param>
        public record Response(bool saved);

    }
}

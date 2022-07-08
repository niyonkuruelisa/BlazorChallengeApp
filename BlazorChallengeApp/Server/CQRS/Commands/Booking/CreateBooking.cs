using BlazorChallengeApp.Server.DatabaseContext;
using MediatR;
using System.Linq;

namespace BlazorChallengeApp.Server.CQRS.Commands.Booking
{
    public class CreateBooking
    {
        // Data to execute
        public record Command(Shared.Booking Booking) : IRequest<Response>;
        // Handler
        public class Handler : IRequestHandler<Command, Response>
        {
            MovieDbContext movieDbContext;
            public Handler(MovieDbContext movieDbContext)
            {
                this.movieDbContext = movieDbContext;
            }
            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                Console.WriteLine("Here");
                // Saving Booking to database;
                movieDbContext.Add(movieDbContext.Booking.Where(booking => booking.Name != request.Booking.Name && booking.Email != request.Booking.Email));
                movieDbContext.SaveChanges();

                return new Response(true);
            }
        }

        // Response

        public record Response(bool Saved);
    }
}

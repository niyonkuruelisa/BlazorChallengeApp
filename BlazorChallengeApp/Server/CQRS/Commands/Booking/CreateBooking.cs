using BlazorChallengeApp.Server.DatabaseContext;
using BlazorChallengeApp.Shared;
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
                
                // Saving Booking to database;
                movieDbContext.Booking.Add(request.Booking);
                // Saving Seats to database;
                movieDbContext.SaveChanges();

                return new Response(true);
            }
        }

        // Response

        public record Response(bool Saved);
    }
}

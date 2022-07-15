using BlazorChallengeApp.Server.CQRS.Commands.Booking;
using BlazorChallengeApp.Server.CQRS.Queries.Booking;
using BlazorChallengeApp.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorChallengeApp.Server.Controllers
{
    public class BookingController : Controller
    {
        IMediator mediator;
        public BookingController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("Booking")]
        public async Task<List<Booking>> GetAllBooKingsByMovie(int? movieId,string day,string time)
        {

            try
            {
                //Save Booking
                var response = await mediator.Send(new GetAllBooKingsByMovie.Query(movieId, day, time));

                return response.Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPost("Booking")]
        public async Task<bool> create([FromBody] Booking booking)
        {

             try
            {

                //Save Booking
                var response = await mediator.Send(new CreateBooking.Command(booking));

                return response.Saved;
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

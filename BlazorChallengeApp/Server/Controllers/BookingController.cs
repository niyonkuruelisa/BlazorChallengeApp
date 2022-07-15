using BlazorChallengeApp.Server.CQRS.Commands.Booking;
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

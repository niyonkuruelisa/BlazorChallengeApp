using BlazorChallengeApp.Server.CQRS.Commands.Booking;
using BlazorChallengeApp.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChallengeApp.Server.Controllers
{

    [Route("[controller]")]
    public class BookingContoller: ControllerBase
    {
        IMediator mediator;
        public BookingContoller(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> create(Booking booking)
        {
            try
            {

                //Save Booking
                var response = await mediator.Send(new CreateBooking.Command(booking));

                return Ok(response.Saved);
            }
            catch(Exception e)
            {

                return NotFound("Something Happened.");
            }
        }

    }
}

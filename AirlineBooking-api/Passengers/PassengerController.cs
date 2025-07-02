using AirlineBooking_api.Passengers.Dtos;
using AirlineBooking_api.Passengers.Exceptions;
using AirlineBooking_api.Passengers.Service;
using Microsoft.AspNetCore.Mvc;

namespace AirlineBooking_api.Passengers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class PassengerController: ControllerBase
    {
        private readonly IQueryServicePassenger _query;
        private readonly ICommandSerivcePassenger _command;

        public PassengerController(IQueryServicePassenger query, ICommandSerivcePassenger command)
        {
            _query = query;
            _command = command;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<PassengerResponse>> AllPassenger()
        {
            try
            {
                GetAllPassengersDto resp = await _query.GetAllAsync();
                return Ok(resp);
            }catch(PassengerNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

    }
}

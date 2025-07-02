using AirlineBooking_api.System;

namespace AirlineBooking_api.Passengers.Exceptions
{
    public class PassengerAlreadyExistException:Exception
    {
        public PassengerAlreadyExistException(): base(ExceptionMessage.PassengerAlreadyExistException) { }
    }
}

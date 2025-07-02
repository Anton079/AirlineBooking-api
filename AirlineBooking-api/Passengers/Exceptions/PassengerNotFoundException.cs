using AirlineBooking_api.System;

namespace AirlineBooking_api.Passengers.Exceptions
{
    public class PassengerNotFoundException:Exception
    {
        public PassengerNotFoundException() : base(ExceptionMessage.PassengerNotFoundException) { }
    }
}

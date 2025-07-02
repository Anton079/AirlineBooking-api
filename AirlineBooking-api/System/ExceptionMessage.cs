namespace AirlineBooking_api.System
{
    public class ExceptionMessage : Exception
    {
        public const string PassengerNotFoundException = "Passenger nu a fost gasit!";
        public const string PassengerAlreadyExistException = "Passenger deja exista!";
    }
}

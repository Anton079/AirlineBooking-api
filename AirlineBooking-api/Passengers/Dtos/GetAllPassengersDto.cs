namespace AirlineBooking_api.Passengers.Dtos
{
    public class GetAllPassengersDto
    {
        public List<PassengerResponse> ListPassengers { get; set; } = new();
    }
}

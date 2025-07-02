namespace AirlineBooking_api.Passengers.Dtos
{
    public class PassengerUpdateRequest
    {
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
    }
}

using AirlineBooking_api.Passengers.Dtos;

namespace AirlineBooking_api.Passengers.Service
{
    public interface IQueryServicePassenger
    {
        Task<GetAllPassengersDto> GetAllAsync();
    }
}

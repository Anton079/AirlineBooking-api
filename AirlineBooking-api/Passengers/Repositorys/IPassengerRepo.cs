using AirlineBooking_api.Passengers.Dtos;

namespace AirlineBooking_api.Passengers.Repositorys
{
    public interface IPassengerRepo
    {
        Task<GetAllPassengersDto> GetAllAsync();
    }
}

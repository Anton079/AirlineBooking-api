using AirlineBooking_api.Passengers.Dtos;
using AirlineBooking_api.Passengers.Exceptions;
using AirlineBooking_api.Passengers.Repositorys;

namespace AirlineBooking_api.Passengers.Service
{
    public class QueryServicePassenger:IQueryServicePassenger
    {
        private readonly IPassengerRepo _repo;

        public QueryServicePassenger(IPassengerRepo repo)
        {
            _repo = repo;
        }

        public async Task<GetAllPassengersDto> GetAllAsync()
        {
            GetAllPassengersDto response = await _repo.GetAllAsync();

            if(response != null)
            {
                return response;
            }

            throw new PassengerNotFoundException();
        }
    }
}

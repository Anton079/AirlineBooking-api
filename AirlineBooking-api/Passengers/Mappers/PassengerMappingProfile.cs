using AirlineBooking_api.Passengers.Dtos;
using AirlineBooking_api.Passengers.Models;
using AutoMapper;

namespace AirlineBooking_api.Passengers.Mappers
{
    public class PassengerMappingProfile:Profile
    {
        public PassengerMappingProfile()
        {
            CreateMap<PassengerRequest, Passenger>();
            CreateMap<Passenger, PassengerResponse>();
            CreateMap<PassengerResponse, PassengerUpdateRequest>();
        }
    }
}

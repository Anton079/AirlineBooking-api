using AirlineBooking_api.Data;
using AirlineBooking_api.Passengers.Dtos;
using AirlineBooking_api.Passengers.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AirlineBooking_api.Passengers.Repositorys
{
    public class PassengerRepo : IPassengerRepo
    {
        private readonly AppDbContext _ctx;
        private readonly IMapper _mapper;

        public PassengerRepo(AppDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<GetAllPassengersDto> GetAllAsync()
        {
            var passengers = await _ctx.Passengers
                .Include(p => p.Tickets)
                      .ThenInclude(t => t.Airplane)
                .AsNoTracking()
                .ToListAsync();

            var mapped = _mapper.Map<List<PassengerResponse>>(passengers);

            return new GetAllPassengersDto
            {
                ListPassengers = mapped
            };
        }
    }
}

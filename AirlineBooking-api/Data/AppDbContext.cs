using AirlineBooking_api.AirplaneCompanys.Models;
using AirlineBooking_api.Airplanes.Models;
using AirlineBooking_api.Passengers.Models;
using AirlineBooking_api.Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineBooking_api.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AirplaneCompany> AirplaneCompanys { get; set; }
        public DbSet<Airplane> AirPlanes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AirplaneCompany>()
                .HasMany(a => a.AirPlanes)
                .WithOne(a => a.AirplaneCompany)
                .HasForeignKey(a => a.AirplaneCompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Passenger>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Passenger)
                .HasForeignKey(t => t.PassengerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Airplane>()
                .HasMany(a => a.Tickets)
                .WithOne(t => t.Airplane)
                .HasForeignKey(t => t.AirplaneId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

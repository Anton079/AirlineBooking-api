using AirlineBooking_api.AirplaneCompanys.Models;
using AirlineBooking_api.Airplanes.Models;
using AirlineBooking_api.Tickets.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AirlineBooking_api.Passengers.Models
{
    [Table("passenger")]
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("passengerId")]
        public int PassengerId { get; set; }

        [Required]
        [Column("fullName")]
        public string FullName {  get; set; }

        [Required]
        [Column("phone")]
        public string Phone {  get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("userName")]
        public string UserName { get; set; }

        [Required]
        [Column("password")]
        public string Password { get; set; }

        [Required]
        [Column("address")]
        public string Address { get; set; }

        public Airplane Airplanes { get; set; }

        public List<Ticket> Tickets { get; set; } = new();

    }
}

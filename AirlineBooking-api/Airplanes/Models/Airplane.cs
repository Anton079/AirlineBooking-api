using AirlineBooking_api.AirplaneCompanys.Models;
using AirlineBooking_api.Tickets.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AirlineBooking_api.Airplanes.Models
{
    [Table("airplane")]
    public class Airplane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("modelPlane")]
        public string ModelPlane {  get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("price")]
        public int Price { get; set; }

        public int AirplaneCompanyId {  get; set; }

        public AirplaneCompany AirplaneCompany { get; set; }

        public List<Ticket> Tickets { get; set; } = new();

    }
}

using AirlineBooking_api.Airplanes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineBooking_api.AirplaneCompanys.Models
{
    [Table("airplaneCompany")]
    public class AirplaneCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("rating")]
        public int Rating { get; set; }

        public List<Airplane> AirPlanes { get; set; } = new();
    }
}

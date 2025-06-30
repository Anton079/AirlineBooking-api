using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineBooking_api.Airplanes.Models
{
    [Table("airplane")]
    public class Airplane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("bookingId")]
        public int Id { get; set; }




    }
}

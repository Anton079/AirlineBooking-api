using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AirlineBooking_api.Airplanes.Models;
using AirlineBooking_api.Passengers.Models;

namespace AirlineBooking_api.Tickets.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ticketId")]
        public int Id { get; set; }

        [Required]
        [Column("ticketDate")]
        public DateTime TicketDate { get; set; }

        [Required]
        [Column("ticketDescription")]
        public string TicketDescription { get; set; }


        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }


        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace BoardDealerWebApp.Models
{
    public class BookingRegister
    {
        [Key]
        public int RegisterId { get; set; }
        public DateTime BookingTime { get; set; } = DateTime.Now;
        public int RentalPeriod { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public int GameId { get; set; }

    }
}

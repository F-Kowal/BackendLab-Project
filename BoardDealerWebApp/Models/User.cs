using System.ComponentModel.DataAnnotations;

namespace BoardDealerWebApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mail { get; set; }
        [MaxLength(9)]
        public string PhoneNumber { get; set; }

    }
}

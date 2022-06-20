using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardDealerWebApp.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Producer { get; set; }
        public bool Available { get; set; } = true;

        [ForeignKey("User")]
        public int? UserId { get; set; } = null;
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
    }
}

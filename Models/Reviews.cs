using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Homestay.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        public Guid HomeId { get; set; }
        public Home home { get; set; }
        public string Comment { get; set; }
        public DateTime Postedtime { get; set; }
        public int Rating { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;

namespace Homestay.Models
{
    public class User
    {
        [Key]
        public int UserId { get;set;  }
        public string UserName { get;set; }
        public string ProfilePhoto {  get;set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Bio { get; set; }
        public ICollection<Booking> bookings { get; set; }
        public ICollection<Reviews> reviews { get; set; }



    }
}

namespace Homestay.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Guid HomeId { get; set; }
        public Home home { get; set; }

        public int UserId { get; set; } 
        public User user { get; set; }

        public DateTime Check_In { get; set; }

        public DateTime Check_Out { get; set; }

        public PaymentStatus status { get; set; }

    }
    public enum PaymentStatus
    {
        Pending,
        Paid,
        UnPaid
    }
}

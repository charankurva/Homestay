namespace Homestay.Models
{
    public class Booking
    {
        public int Booking_Id { get; set; }
        public Guid Home_Id { get; set; }

        public int User_Id { get; set; } 

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

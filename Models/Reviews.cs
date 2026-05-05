namespace Homestay.Models
{
    public class Reviews
    {
        public int Review_Id { get; set; }
        public Guid Homeid { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }

    }
}

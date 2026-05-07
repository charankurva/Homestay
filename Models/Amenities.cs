namespace Homestay.Models
{
    public class Amenities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public Guid HomeId { get; set; }
        public Home home { get; set; }

    }
}

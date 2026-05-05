namespace Homestay.Models
{
    public class Home
    {
        public Guid Homeid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }

        public int Price { get; set; }

        public HomeType homeType { get; set; }

        public ICollection<Amenities> Amenities { get; set; }

    }

    public class Address
    {
        public string StreetAddress { get; set; }
        public string NearLandmark { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
    }
    
    public class HomeType
    {
        public int Guests { get; set; }
        public int Bedrooms { get; set; }
        public int Bathroom { get; set; }
    }

}

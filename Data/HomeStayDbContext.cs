using Homestay.Models;
using Microsoft.EntityFrameworkCore;

namespace Homestay.Data
{
    public class HomeStayDbContext(DbContextOptions<HomeStayDbContext> options):DbContext(options)
    {
        public DbSet<Home> homes=>Set<Home>();
        public DbSet<Amenities> amenities=>Set<Amenities>();
        public DbSet<Booking> bookings=>Set<Booking>(); 
        public DbSet<Reviews> reviews=>Set<Reviews>();  

        public DbSet<User> users=>Set<User>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(HomeStayDbContext).Assembly);

        }
    }
}

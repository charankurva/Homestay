using Homestay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homestay.Data
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasOne(b => b.home).WithMany(b => b.bookings).HasForeignKey(b=>b.HomeId);
            builder.HasOne(b => b.user).WithMany(b => b.bookings).HasForeignKey(b=>b.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

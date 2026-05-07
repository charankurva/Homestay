using Homestay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homestay.Data
{
    public class HomeConfiguration : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.ToTable("Homes");
            builder.HasKey(h=>h.HomeId);
            builder.Property(h=>h.HomeId).IsRequired();
            builder.HasMany(h => h.Amenities).WithOne(h=>h.home).HasForeignKey(h=>h.HomeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(h => h.Reviews).WithOne(h => h.home).HasForeignKey(h => h.HomeId).OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}

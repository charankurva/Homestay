using Homestay.Models;
using Microsoft.EntityFrameworkCore;

namespace Homestay.Data
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Reviews> builder)
        {
            builder.HasOne(r=>r.user).WithMany(r=>r.reviews).OnDelete(DeleteBehavior.NoAction).HasForeignKey(r=>r.UserId);
        }
    }
}

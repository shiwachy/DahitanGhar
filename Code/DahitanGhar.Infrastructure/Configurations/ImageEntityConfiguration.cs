using DahitanGhar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DahitanGhar.Infrastructure.Configurations;

public class ImageEntityConfiguration : IEntityTypeConfiguration<ImageEntity>
{
    public void Configure(EntityTypeBuilder<ImageEntity> builder)
    {
        builder.HasKey(x => x.ImageId);
        builder.HasOne(x => x.Description)
                .WithOne(x => x.Image)
                .HasForeignKey<ImageDescriptionEntity>(x => x.ImageId);
    }
}

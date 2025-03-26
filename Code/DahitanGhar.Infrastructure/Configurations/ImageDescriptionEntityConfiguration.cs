using DahitanGhar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DahitanGhar.Infrastructure.Configurations;

class ImageDescriptionEntityConfiguration : IEntityTypeConfiguration<ImageDescriptionEntity>
{
    public void Configure(EntityTypeBuilder<ImageDescriptionEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Image)
                .WithOne(x => x.Description)
                .HasForeignKey<ImageDescriptionEntity>(x => x.ImageId);
    }
}

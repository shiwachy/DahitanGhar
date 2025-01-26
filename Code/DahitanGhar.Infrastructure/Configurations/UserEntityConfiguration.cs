using DahitanGhar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DahitanGhar.Infrastructure.Configurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x=>x.UserName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.PasswordHash)
            .IsRequired()
            .HasMaxLength(2000);
        builder.Property(x => x.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);
         builder.Property(x => x.RefreshToken)
            .IsRequired()
            .HasMaxLength(500);
        builder.Property(x => x.RefreshTokenExpiryTime)
            .IsRequired()
            .HasColumnType("DateTimeOffset");
    }
}

using DahitanGhar.Application.Interfaces;
using DahitanGhar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DahitanGhar.Infrastructure.DbSet;

public class DgDbContext: DbContext, IDgDbContext
{
    public DgDbContext(DbContextOptions<DgDbContext> options) : base(options)
    {

    }

    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>().ToTable("Mst_Users");
    }
}

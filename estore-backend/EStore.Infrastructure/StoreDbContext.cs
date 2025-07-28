using EStore.Domain;
using EStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EStore.Infrastructure;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<VolumePrice>()
            .Property(vp => vp.Value)
            .HasColumnType("decimal(18,2)");    
    }

}
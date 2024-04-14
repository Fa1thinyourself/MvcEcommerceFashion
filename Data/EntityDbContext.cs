using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEcommerceFashion.Models.EntityModels;

namespace MvcEcommerceFashion.Data
{
  public class EntityDbContext : DbContext
  {
    public EntityDbContext(DbContextOptions<EntityDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Product>().Property(b => b.CreatedAt).HasDefaultValueSql("GETDATE()");
      modelBuilder.Entity<Product>().Property(b => b.UpdatedAt).HasDefaultValueSql("GETDATE()");
    }

    public DbSet<Product> Product { get; set; } = default!;
    public DbSet<Category> Category { get; set; } = default!;
  }

}

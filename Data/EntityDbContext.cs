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
        public EntityDbContext (DbContextOptions<EntityDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcEcommerceFashion.Models.EntityModels.Product> Product { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
    }
}

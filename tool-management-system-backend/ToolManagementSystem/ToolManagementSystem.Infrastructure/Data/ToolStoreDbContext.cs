using Microsoft.EntityFrameworkCore;
using ToolManagementSystem.Domain.Entities;
using ToolManagementSystem.Infrastructure.Data.Configurations;

namespace ToolManagementSystem.Infrastructure.Data;

public class ToolStoreDbContext : DbContext
{
    public DbSet<Aircraft> Aircrafts { get; set; }

    public DbSet<Toolbox> Toolboxes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tool> Tools { get; set; }

    public ToolStoreDbContext(DbContextOptions<ToolStoreDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToolConfiguration).Assembly);
    }
}

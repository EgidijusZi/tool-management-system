using Microsoft.EntityFrameworkCore;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Infrastructure.Data;

public class ToolStoreDbContext : DbContext
{
    public DbSet<Aircraft> Aircrafts { get; set; }

    public DbSet<Toolbox> Toolboxes { get; set; }
    public DbSet<User> Users { get; set; }

    public ToolStoreDbContext(DbContextOptions<ToolStoreDbContext> options) : base(options)
    {
    }
}

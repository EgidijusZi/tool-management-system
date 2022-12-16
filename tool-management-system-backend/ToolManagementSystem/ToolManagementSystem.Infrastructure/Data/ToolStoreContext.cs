using Microsoft.EntityFrameworkCore;
using ToolManagementSystem.Domain.Models;

namespace ToolManagementSystem.Infrastructure.Data
{
    public class ToolStoreContext : DbContext
    {
        public ToolStoreContext(DbContextOptions<ToolStoreContext> options) : base(options)
        { }

        public DbSet<Aircraft> Aircrafts { get; set; }
    }
}

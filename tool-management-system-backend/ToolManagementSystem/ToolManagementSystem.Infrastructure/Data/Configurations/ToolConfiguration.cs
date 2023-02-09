using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Infrastructure.Data.Configurations
{
    public class ToolConfiguration : IEntityTypeConfiguration<Tool>
    {
        public void Configure(EntityTypeBuilder<Tool> builder)
        {

            builder.HasOne(d => d.User)
                .WithMany(p => p.UsedTools)
                .HasForeignKey(d => d.UserId);
        }
    }
}

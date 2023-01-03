using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateToken(User user);
        public Guid? ValidateToken(string token);
    }
}

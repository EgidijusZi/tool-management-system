using ToolManagementSystem.Domain.Models;

namespace ToolManagementSystem.Core.Services
{
    public interface IAircraftService
    {
        public List<Aircraft> GetAllAircrafts();
    }
}

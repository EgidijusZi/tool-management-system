using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces;

public interface IAircraftRepository
    {
        IEnumerable<Aircraft> GetAll();
    }

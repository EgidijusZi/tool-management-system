using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces;

public interface IToolboxRepository
{
    IEnumerable<Toolbox> GetAll();
}

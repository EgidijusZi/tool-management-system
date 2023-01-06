using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces;

public interface IAircraftRepository
    {
    IEnumerable<Aircraft> GetAll();

    Aircraft GetById(Guid id);

    Aircraft Create(Aircraft aircraft);

    Aircraft Update(Aircraft aircraft);

    void Delete(Guid id);
}

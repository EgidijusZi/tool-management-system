using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces;

public interface IToolboxRepository
{
    IEnumerable<Toolbox> GetAll();

    Toolbox GetById(Guid id);

    Toolbox Create(Toolbox toolbox);

    Toolbox Update(Toolbox toolbox);

    void Delete(Guid id);
}

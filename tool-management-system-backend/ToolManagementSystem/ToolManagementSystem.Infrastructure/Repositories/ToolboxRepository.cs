using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Infrastructure.Data;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Infrastructure.Repositories;

public class ToolboxRepository : IToolboxRepository
{ 
    private readonly ToolStoreDbContext _dbContext;
    public ToolboxRepository(ToolStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Toolbox> GetAll()
    {
        var toolboxes = _dbContext.Toolboxes.ToList();
        return toolboxes;
    }
}

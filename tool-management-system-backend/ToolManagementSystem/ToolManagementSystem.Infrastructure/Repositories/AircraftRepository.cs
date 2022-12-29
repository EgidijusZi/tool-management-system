
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Domain.Entities;
using ToolManagementSystem.Infrastructure.Data;

namespace ToolManagementSystem.Infrastructure.Repositories;

public class AircraftRepository : IAircraftRepository
{
    private readonly ToolStoreDbContext _dbContext;

    public AircraftRepository(ToolStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Aircraft> GetAll()
    {
        var aircrafts = _dbContext.Aircrafts.ToList();
        return aircrafts;
    }
}

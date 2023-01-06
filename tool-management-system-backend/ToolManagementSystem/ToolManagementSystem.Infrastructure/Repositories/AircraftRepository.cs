using Microsoft.EntityFrameworkCore;
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

    public Aircraft Create(Aircraft aircraft)
    {
        aircraft.Id = Guid.NewGuid();
        _dbContext.Aircrafts.Add(aircraft);
        _dbContext.SaveChanges();

        return aircraft;
    }

    public void Delete(Guid id)
    {
        var aircraft = _dbContext.Aircrafts.SingleOrDefault(aircraft => aircraft.Id == id);

        if (aircraft is null)
        {
            throw new Exception("Aircraft not found");
        }

        _dbContext.Aircrafts.Remove(aircraft);
        _dbContext.SaveChanges();
    }

    public IEnumerable<Aircraft> GetAll()
    {
        var aircrafts = _dbContext.Aircrafts.ToList();
        return aircrafts;
    }

    public Aircraft GetById(Guid id)
    {
        var aircraft = _dbContext.Aircrafts.FirstOrDefault(aircraft => aircraft.Id == id);
        return aircraft;
    }

    public Aircraft Update(Aircraft aircraft)
    {
        var local = _dbContext.Aircrafts
                .Local
                .FirstOrDefault(oldAircraft => oldAircraft.Id == aircraft.Id);

        if (local != null)
        {
            _dbContext.Entry(local).State = EntityState.Detached;
        }

        _dbContext.Entry(aircraft).State = EntityState.Modified;
        _dbContext.SaveChanges();

        return aircraft;
    }
}

using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Infrastructure.Data;
using ToolManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ToolManagementSystem.Infrastructure.Repositories;

public class ToolboxRepository : IToolboxRepository
{ 
    private readonly ToolStoreDbContext _dbContext;
    public ToolboxRepository(ToolStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Toolbox Create(Toolbox toolbox)
    {
        toolbox.Id = Guid.NewGuid();
        _dbContext.Toolboxes.Add(toolbox);
        _dbContext.SaveChanges();

        return toolbox;
    }

    public void Delete(Guid id)
    {
        var toolbox = _dbContext.Toolboxes.SingleOrDefault(toolbox => toolbox.Id == id);

        if (toolbox is null)
        {
            throw new Exception("Toolbox not found");
        }

        _dbContext.Toolboxes.Remove(toolbox);
        _dbContext.SaveChanges();
    }

    public IEnumerable<Toolbox> GetAll()
    {
        var toolboxes = _dbContext.Toolboxes.ToList();
        return toolboxes;
    }

    public Toolbox GetById(Guid id)
    {
        var toolbox = _dbContext.Toolboxes.FirstOrDefault(toolbox => toolbox.Id == id);
        return toolbox;
    }

    public Toolbox Update(Toolbox toolbox)
    {
        var local = _dbContext.Toolboxes
                .Local
                .FirstOrDefault(oldToolbox => oldToolbox.Id == toolbox.Id);

        if (local != null)
        {
            _dbContext.Entry(local).State = EntityState.Detached;
        }

        _dbContext.Entry(toolbox).State = EntityState.Modified;
        _dbContext.SaveChanges();

        return toolbox;
    }
}

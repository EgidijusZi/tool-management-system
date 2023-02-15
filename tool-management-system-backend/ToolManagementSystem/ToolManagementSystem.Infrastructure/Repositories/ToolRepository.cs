using Microsoft.EntityFrameworkCore;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Domain.Entities;
using ToolManagementSystem.Infrastructure.Data;

namespace ToolManagementSystem.Infrastructure.Repositories
{
    public class ToolRepository : IToolRepository
    {
        private readonly ToolStoreDbContext _dbContext;
        public ToolRepository(ToolStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Tool Create(Tool tool)
        {
            tool.Id = Guid.NewGuid();
            _dbContext.Tools.Add(tool);
            _dbContext.SaveChanges();

            return tool;
        }

        public void Delete(Guid id)
        {
            var tool = _dbContext.Tools.SingleOrDefault(tool => tool.Id == id);

            if (tool is null)
            {
                throw new Exception("Tool not found");
            }

            _dbContext.Tools.Remove(tool);
            _dbContext.SaveChanges();
        }
        public IEnumerable<Tool> GetAllTakenTools()
        {
            var takenTools = new List<Tool>();
            foreach (var tool in _dbContext.Tools)
            {
                if (tool.User is not null)
                {
                    takenTools.Add(tool);
                }
            }

            return takenTools;

        }
        public IEnumerable<Tool> GetAll()
        {
            var tools = _dbContext.Tools.ToList();
            return tools;
        }

        public Tool GetById(Guid id)
        {
            var tool = _dbContext.Tools.FirstOrDefault(tool => tool.Id == id);
            return tool;
        }

        public Tool Update(Tool tool)
        {
            var local = _dbContext.Tools
                    .Local
                    .FirstOrDefault(oldTool => oldTool.Id == tool.Id);

            if (local != null)
            {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(tool).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return tool;
        }
    }

}

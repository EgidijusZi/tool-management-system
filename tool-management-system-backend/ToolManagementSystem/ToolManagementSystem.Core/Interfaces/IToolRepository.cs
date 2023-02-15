using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IToolRepository
    {
        IEnumerable<Tool> GetAllTakenTools();
        IEnumerable<Tool> GetAll();

        Tool GetById(Guid id);

        Tool Create(Tool tool);

        Tool Update(Tool tool);

        void Delete(Guid id);
    }
}

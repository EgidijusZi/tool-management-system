using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces;

public interface IToolboxService
{
    IEnumerable<ToolboxResponseDto> GetAll();
}

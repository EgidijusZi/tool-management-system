using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces;

public interface IToolboxService
{
    IEnumerable<ToolboxResponseDto> GetAll();

    ToolboxResponseDto GetById(Guid id);

    ToolboxResponseDto Create(ToolboxRequestDto request);

    ToolboxResponseDto Update(Guid id, ToolboxRequestDto request);

    void Delete(Guid id);
}

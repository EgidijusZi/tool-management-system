using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IToolService
    {
        IEnumerable<ToolResponseDto> GetAll();

        ToolResponseDto GetById(Guid id);

        ToolResponseDto Create(ToolRequestDto request);

        ToolResponseDto Update(Guid id, ToolRequestDto request);

        void Delete(Guid id);
    }
}

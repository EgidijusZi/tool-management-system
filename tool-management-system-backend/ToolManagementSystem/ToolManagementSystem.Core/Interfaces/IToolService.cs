using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IToolService
    {
        ToolPickupResponseDto PickUp(ToolPickupRequestDto request);
        IEnumerable<ToolResponseDto> GetAll();
        IEnumerable<ToolResponseDto> GetAllTakenTools();

        ToolResponseDto GetById(Guid id);

        ToolResponseDto Create(ToolCreationRequestDto request);

        ToolResponseDto Update(Guid id, ToolCreationRequestDto request);

        void Delete(Guid id);
    }
}

using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces;
public interface IAircraftService
{
    IEnumerable<AircraftResponseDto> GetAll();

    AircraftResponseDto GetById(Guid id);

    AircraftResponseDto Create(AircraftRequestDto request);

    AircraftResponseDto Update(Guid id, AircraftRequestDto request);

    void Delete(Guid id);
}


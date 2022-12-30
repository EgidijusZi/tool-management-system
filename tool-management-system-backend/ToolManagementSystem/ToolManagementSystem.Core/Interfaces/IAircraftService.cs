using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces;
public interface IAircraftService
{
    IEnumerable<AircraftResponseDto> GetAll();
}


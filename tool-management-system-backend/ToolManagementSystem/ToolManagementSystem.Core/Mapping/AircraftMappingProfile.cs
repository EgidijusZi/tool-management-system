using AutoMapper;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping;

public class AircraftMapping : Profile
{
    public AircraftMapping()
    {
        CreateMap<Aircraft, AircraftResponseDto>();
    }
}
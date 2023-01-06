using AutoMapper;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping;

public class AircraftMappingProfile : Profile
{
    public AircraftMappingProfile()
    {
        CreateMap<AircraftResponseDto, Aircraft>();
        CreateMap<Aircraft, AircraftResponseDto>();
    }
}
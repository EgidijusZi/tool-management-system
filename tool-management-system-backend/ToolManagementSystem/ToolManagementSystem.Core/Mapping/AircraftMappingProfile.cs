using AutoMapper;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping;

public class AircraftMappingProfile : Profile
{
    public AircraftMappingProfile()
    {
        CreateMap<AircraftRequestDto, Aircraft>();
        CreateMap<Aircraft, AircraftResponseDto>();
    }
}
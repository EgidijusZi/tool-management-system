using AutoMapper;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping;

public class ToolboxMappingProfile : Profile
{
    public ToolboxMappingProfile()
    {
        CreateMap<Toolbox, ToolboxResponseDto>();
        CreateMap<ToolboxRequestDto, Toolbox>();
    }
}

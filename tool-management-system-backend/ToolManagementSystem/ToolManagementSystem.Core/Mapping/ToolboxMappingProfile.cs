using AutoMapper;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping;

public class ToolboxMappingProfile : Profile
{
    public ToolboxMappingProfile()
    {
        CreateMap<Toolbox, ToolboxResponseDto>();
    }
}

using AutoMapper;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping
{
    public class ToolMappingProfile : Profile
    {
        public ToolMappingProfile()
        {
            CreateMap<Tool, ToolResponseDto>();
            CreateMap<ToolRequestDto, Tool>();
        }
    }

}

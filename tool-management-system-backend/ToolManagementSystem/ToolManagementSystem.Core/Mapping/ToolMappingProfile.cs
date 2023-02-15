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
            CreateMap<Tool, ToolCreationResponseDto>();
            CreateMap<ToolCreationRequestDto, Tool>();
            CreateMap<Tool, ToolPickupResponseDto>();
            CreateMap<ToolPickupRequestDto, Tool>();
            CreateMap<Tool, ToolResponseDto>();
        }
    }

}

using AutoMapper;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile() 
        {
            CreateMap<User, AuthenticateResponseDto>();
            CreateMap<UserRegisterRequestDto, User>();
            CreateMap<UserUpdateRequestDto, User>();
            CreateMap<User, UserResponseDto>();
        }
    }
}

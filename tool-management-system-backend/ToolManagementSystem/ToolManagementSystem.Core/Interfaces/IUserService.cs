using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponseDto Authenticate(AuthenticateRequestDto request);
        UserResponseDto GetById(Guid id);

        IEnumerable<UserResponseDto> GetAll();

        UserResponseDto Register(UserRegisterRequestDto request);

        UserResponseDto Update(Guid id, UserUpdateRequestDto request);

        void Delete(Guid id);
    }
}

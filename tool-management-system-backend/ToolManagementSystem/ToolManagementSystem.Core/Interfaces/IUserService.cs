﻿using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponseDto Authenticate(AuthenticateRequestDto request);
        UserResponseDto GetById(Guid id);

        IEnumerable<UserResponseDto> GetAll();

        UserResponseDto Register(RegisterRequestDto request);

        UserResponseDto Update(Guid id, UpdateRequestDto request);

        void Delete(Guid id);
    }
}

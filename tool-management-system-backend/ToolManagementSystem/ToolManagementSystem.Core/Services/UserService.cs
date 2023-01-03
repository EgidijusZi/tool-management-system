using AutoMapper;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Core.Helpers;
using ToolManagementSystem.Domain.Entities;
using BCryptNet = BCrypt.Net.BCrypt;

namespace ToolManagementSystem.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtUtils _jwtUtils;
        private readonly IMapper _mapper;
        
        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils, IMapper mapper) 
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
        }

        public AuthenticateResponseDto Authenticate(AuthenticateRequestDto request)
        {
            var user = _userRepository.FindByEmail(request.Email);

            if (user == null || !BCryptNet.Verify(request.Password, user.PasswordHash)) 
            {
                throw new AppException("Email or password is incorrect");
            }

            var response = _mapper.Map<AuthenticateResponseDto>(user);
            response.Token = _jwtUtils.GenerateToken(user);
            return response;
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<UserResponseDto> GetAll()
        {
            var users = _userRepository.GetAll();
            var responseList = users.Select(users => _mapper.Map<UserResponseDto>(users));

            return responseList;
        }

        public UserResponseDto GetById(Guid id)
        {
            var user = _userRepository.GetById(id);
            var response = _mapper.Map<UserResponseDto>(user);

            return response;
        }

        public UserResponseDto Register(RegisterRequestDto request)
        {
            var emailExists = _userRepository.FindByEmail(request.Email);
            if (emailExists != null)
            {
                throw new AppException("Email '" + request.Email + "' is already taken");
            }
            var userRegisterRequest = _mapper.Map<User>(request);
            userRegisterRequest.PasswordHash = BCryptNet.HashPassword(request.Password);
            var createdUser = _userRepository.Register(userRegisterRequest);
            var response = _mapper.Map<UserResponseDto>(createdUser);

            return response;
        }

        public UserResponseDto Update(Guid id, UpdateRequestDto request)
        {
            var user = _userRepository.GetById(id);
            if (user is null)
            {
                throw new AppException("User with provided id does not exist");
            }
            var userUpdateRequest = _mapper.Map<User>(request);
            var updatedUser = _userRepository.Update(userUpdateRequest);
            var response = _mapper.Map<UserResponseDto>(updatedUser);

            return response;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ToolManagementSystem.Core.Helpers;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;

namespace ToolManagementSystem.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        public UserController(IUserService userService, IMapper mapper, IOptions<AppSettings> appSettings) 
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequestDto request)
        {
            var response = _userService.Authenticate(request);
            return Ok(response);
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequestDto request)
        {
            _userService.Register(request);
            return Ok(new { message = "Registration successsful" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, UserUpdateRequestDto request)
        {
            _userService.Update(id, request);
            return Ok(new { message = "User updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _userService.Delete(id);
            return Ok(new { message = "User deleted successfully" });
        }
    }


}

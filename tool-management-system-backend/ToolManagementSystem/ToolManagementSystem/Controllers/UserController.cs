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

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequestDto request)
        {
            var response = _userService.Authenticate(request);
            return Ok(response);
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegisterRequestDto request)
        {
            _userService.Register(request);
            return Ok(new { message = "Registration successful" });
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

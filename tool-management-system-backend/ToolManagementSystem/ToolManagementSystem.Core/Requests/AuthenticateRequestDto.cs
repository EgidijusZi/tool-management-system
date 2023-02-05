using System.ComponentModel.DataAnnotations;

namespace ToolManagementSystem.Core.Requests
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Requests
{
    public class UserRegisterRequestDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ThreeLetterCode { get; set; }
        [Required]
        public string Email { get; set; } 
        public Role Role { get; set; }
    }
}

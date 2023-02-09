using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Responses
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThreeLetterCode { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}

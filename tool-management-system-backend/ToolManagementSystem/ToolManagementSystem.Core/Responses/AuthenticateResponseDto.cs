using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Responses
{
    public class AuthenticateResponseDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThreeLetterCode { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public AuthenticateResponseDto(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            ThreeLetterCode = user.ThreeLetterCode;
            Email = user.Email;
            Role = user.Role;
            Token = token;
        }
    }
}

namespace ToolManagementSystem.Core.Requests
{
    public class UserRegisterRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThreeLetterCode { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
    }
}

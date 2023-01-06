namespace ToolManagementSystem.Core.Requests
{
    public class UserUpdateRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThreeLetterCode { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        
    }
}

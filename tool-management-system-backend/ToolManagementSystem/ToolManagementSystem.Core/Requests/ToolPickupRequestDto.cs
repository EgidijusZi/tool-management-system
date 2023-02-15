namespace ToolManagementSystem.Core.Requests
{
    public class ToolPickupRequestDto
    {
        public Guid Id { get; set; }
        public Guid TakenById { get; set; }
        public string ToolDescription { get; set; }
        public string ToolMarking { get; set; }
    }
}

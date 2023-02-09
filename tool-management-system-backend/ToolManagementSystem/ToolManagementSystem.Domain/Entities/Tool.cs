namespace ToolManagementSystem.Domain.Entities
{
    public class Tool
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string ToolDescription { get; set; }
        public string ToolMarking { get; set; }
        public virtual User? User { get; set; }
    }

}

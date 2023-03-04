namespace ToolManagementSystem.Domain.Entities
{
    public class Engine
    {
        public Guid Id { get; set; }
        public string EngineType { get; set; }
        public int CSN { get; set; }
        public int TSN { get; set; }
    }
}

using Newtonsoft.Json;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Responses
{
    public class ToolResponseDto
    {
        public Guid Id { get; set; }
        public string ToolDescription { get; set; }
        public string ToolMarking { get; set; }
        public virtual UserTakenToolsResponseDto User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ToolManagementSystem.Domain.Entities;

public class Toolbox
{
    public Guid Id { get; set; }
    public string ToolboxMarking { get; set; }
    public string Owner { get; set; }
}

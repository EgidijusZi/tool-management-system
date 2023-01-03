using System.ComponentModel.DataAnnotations;

namespace ToolManagementSystem.Domain.Entities;

public class Toolbox
{
    [Key]
    public Guid id { get; set; }
    public string ToolboxMarking { get; set; }
    public string Owner { get; set; }
}

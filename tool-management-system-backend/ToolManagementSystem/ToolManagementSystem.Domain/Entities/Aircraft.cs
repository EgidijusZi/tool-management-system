using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolManagementSystem.Domain.Entities;

public class Aircraft
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [StringLength(6)]
    public string AircraftRegistration { get; set; }
    public string EngineType { get; set; }
    [Required]
    [MaxLength(5)]
    public int ManufacturerSerialNumber { get; set; }
}

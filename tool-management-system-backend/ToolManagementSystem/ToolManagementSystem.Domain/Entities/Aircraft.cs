using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolManagementSystem.Domain.Entities;

public class Aircraft
{
    public Guid Id { get; set; }
    public string AircraftRegistration { get; set; }
    public string EngineType { get; set; }
    public int ManufacturerSerialNumber { get; set; }
}

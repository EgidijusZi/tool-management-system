namespace ToolManagementSystem.Core.Responses;

public class AircraftResponseDto
{
    public Guid Id { get; set; }
    public string AircraftRegistration { get; set; }
    public string EngineType { get; set; }
    public int ManufacturerSerialNumber { get; set; }
}

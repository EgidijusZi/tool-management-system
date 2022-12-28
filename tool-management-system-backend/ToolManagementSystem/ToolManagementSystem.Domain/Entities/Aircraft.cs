using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolManagementSystem.Domain.Entities
{
    public class Aircraft
    {
        [Key]
        Guid Id;
        string AircraftRegistration;
        string EngineType;
        int ManufacturerSerialNumber;
    }
}

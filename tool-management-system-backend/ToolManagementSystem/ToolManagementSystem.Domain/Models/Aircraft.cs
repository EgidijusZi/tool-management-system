using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolManagementSystem.Domain.Models
{
    public class Aircraft
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string AircraftRegistration { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string EngineType { get; set; }
        public int ManufacturerSerialNumber { get; set; }

    }
}

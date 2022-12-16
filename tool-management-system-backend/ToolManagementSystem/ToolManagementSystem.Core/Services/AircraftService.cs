using ToolManagementSystem.Domain.Models;
using ToolManagementSystem.Infrastructure.Data;

namespace ToolManagementSystem.Core.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly ToolStoreContext _aircraftContext;

        public AircraftService(ToolStoreContext aircraftContext)
        {
            _aircraftContext = aircraftContext;
        }

        public List<Aircraft> GetAllAircrafts()
        {
            return _aircraftContext.Aircrafts.ToList();
        }
    }
}

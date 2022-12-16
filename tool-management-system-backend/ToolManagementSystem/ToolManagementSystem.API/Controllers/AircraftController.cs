using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Services;
using ToolManagementSystem.Domain.Models;

namespace ToolManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftController : ControllerBase
    {
        private readonly IAircraftService _aircraftService;

        public AircraftController(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        [HttpGet]
        public ActionResult<List<Aircraft>> GetAllAircrafts()
        {
            return _aircraftService.GetAllAircrafts();
        }
    }
}

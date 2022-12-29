using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Interfaces;

namespace ToolManagementSystem.Api.Controllers;
public class AircraftController : BaseController
{
    private readonly IAircraftService _aircraftService;

    public AircraftController(IAircraftService aircraftService)
    {
        _aircraftService = aircraftService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var aircrafts = _aircraftService.GetAll();
        return Ok(aircrafts);
    }
}

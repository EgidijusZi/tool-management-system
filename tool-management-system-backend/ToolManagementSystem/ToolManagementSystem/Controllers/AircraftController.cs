using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;

namespace ToolManagementSystem.Api.Controllers;
public class AircraftController : BaseController
{
    private readonly IAircraftService _aircraftService;

    public AircraftController(IAircraftService aircraftService)
    {
        _aircraftService = aircraftService;
    }

    [HttpPost]
    public IActionResult Create(AircraftRequestDto request)
    {
        _aircraftService.Create(request);
        return Ok(new { message = "Created successfully" });
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var aircrafts = _aircraftService.GetAll();
        return Ok(aircrafts);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var aircraft = _aircraftService.GetById(id);
        return Ok(aircraft);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, AircraftRequestDto request)
    {
        _aircraftService.Update(id, request);
        return Ok(new { message = "Aircraft updated successfully" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _aircraftService.Delete(id);
        return Ok(new { message = "Aircraft deleted successfully" });
    }
}

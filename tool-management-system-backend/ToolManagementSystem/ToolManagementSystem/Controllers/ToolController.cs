using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;

namespace ToolManagementSystem.Api.Controllers
{
    public class ToolController : BaseController
    {
        private readonly IToolService _toolService;
        public ToolController(IToolService toolService)
        {
            _toolService = toolService;
        }

        [HttpPost]
        public IActionResult Create(ToolRequestDto request)
        {
            _toolService.Create(request);
            return Ok(new { message = "Created successfully" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tools = _toolService.GetAll();
            return Ok(tools);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var tool = _toolService.GetById(id);
            return Ok(tool);
        }

        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id, ToolRequestDto request)
        {
            _toolService.Update(id, request);
            return Ok(new { message = "Tool updated successfully" });
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _toolService.Delete(id);
            return Ok(new { message = "Tool deleted successfully" });
        }
    }
}

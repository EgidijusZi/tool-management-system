using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;

namespace ToolManagementSystem.Api.Controllers
{
    public class ToolboxController : BaseController
    {
        private readonly IToolboxService _toolboxService;
        public ToolboxController(IToolboxService toolboxService)
        {
            _toolboxService = toolboxService;
        }

        [HttpPost]
        public IActionResult Create(ToolboxRequestDto request)
        {
            _toolboxService.Create(request);
            return Ok(new { message = "Created successfully" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var toolboxes = _toolboxService.GetAll();
            return Ok(toolboxes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var toolbox = _toolboxService.GetById(id);
            return Ok(toolbox);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ToolboxRequestDto request)
        {
            _toolboxService.Update(id, request);
            return Ok(new { message = "Toolbox updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _toolboxService.Delete(id);
            return Ok(new { message = "Toolbox deleted successfully" });
        }
    }
}

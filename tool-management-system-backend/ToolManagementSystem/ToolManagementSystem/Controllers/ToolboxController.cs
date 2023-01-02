using Microsoft.AspNetCore.Mvc;
using ToolManagementSystem.Core.Interfaces;

namespace ToolManagementSystem.Api.Controllers
{
    public class ToolboxController : BaseController
    {
        private readonly IToolboxService _toolboxService;
        public ToolboxController(IToolboxService toolboxService)
        {
            _toolboxService = toolboxService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var toolboxes = _toolboxService.GetAll();
            return Ok(toolboxes);
        }
    }
}

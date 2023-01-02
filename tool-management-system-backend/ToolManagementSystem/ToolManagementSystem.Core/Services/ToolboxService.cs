using AutoMapper;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Services;

public class ToolboxService : IToolboxService
{
    private readonly IToolboxRepository _toolboxRepository;
    private readonly IMapper _mapper;

    public ToolboxService(IToolboxRepository toolboxRepository, IMapper mapper)
    {
        _toolboxRepository = toolboxRepository;
        _mapper = mapper;
    }

    public IEnumerable<ToolboxResponseDto> GetAll()
    {
        var toolboxes = _toolboxRepository.GetAll();
        var toolboxDtoList = toolboxes.Select(toolboxes => _mapper.Map<ToolboxResponseDto>(toolboxes));
        return toolboxDtoList;
    }
}

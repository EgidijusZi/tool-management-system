using AutoMapper;
using ToolManagementSystem.Core.Helpers;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

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
        var toolboxDtoList = toolboxes.Select(toolbox => _mapper.Map<ToolboxResponseDto>(toolbox));

        return toolboxDtoList;
    }

    public ToolboxResponseDto Create(ToolboxRequestDto request)
    {
        var requestToolbox = _mapper.Map<Toolbox>(request);
        var createdToolbox = _toolboxRepository.Create(requestToolbox);
        var response = _mapper.Map<ToolboxResponseDto>(createdToolbox);

        return response;
    }

    public void Delete(Guid id)
    {
        _toolboxRepository.Delete(id);
    }

    public ToolboxResponseDto GetById(Guid id)
    {
        var toolbox = _toolboxRepository.GetById(id);
        var response = _mapper.Map<ToolboxResponseDto>(toolbox);

        return response;
    }

    public ToolboxResponseDto Update(Guid id, ToolboxRequestDto request)
    {
        var toolbox = _toolboxRepository.GetById(id);
        if (toolbox is null)
        {
            throw new AppException("Toolbox with provided id does not exist");
        }

        var toolboxUpdateRequest = _mapper.Map<Toolbox>(request);
        toolboxUpdateRequest.Id = id;
        var updatedToolbox = _toolboxRepository.Update(toolboxUpdateRequest);

        var response = _mapper.Map<ToolboxResponseDto>(updatedToolbox);

        return response;
    }
}

using AutoMapper;
using ToolManagementSystem.Core.Helpers;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Services
{
    public class ToolService : IToolService
    {
        private readonly IToolRepository _toolRepository;
        private readonly IMapper _mapper;

        public ToolService(IToolRepository toolRepository, IMapper mapper)
        {
            _toolRepository = toolRepository;
            _mapper = mapper;
        }

        public ToolPickupResponseDto PickUp(ToolPickupRequestDto request)
        {
            var tool = _toolRepository.GetById(request.Id);

            if (tool is null)
            {
                throw new AppException("Tool with provided id does not exist");
            }

            tool.TakenById = request.TakenById;
            var pickedTool = _mapper.Map<Tool>(tool);
            _toolRepository.Update(pickedTool);
            var response = _mapper.Map<ToolPickupResponseDto>(pickedTool);
            return response;
        }

        public IEnumerable<ToolResponseDto> GetAll()
        {
            var tools = _toolRepository.GetAll();
            var toolsDtoList = tools.Select(tool => _mapper.Map<ToolResponseDto>(tool));

            return toolsDtoList;
        }

        public ToolResponseDto Create(ToolCreationRequestDto request)
        {
            var requestTool = _mapper.Map<Tool>(request);
            var createdTool = _toolRepository.Create(requestTool);
            var response = _mapper.Map<ToolResponseDto>(createdTool);

            return response;
        }

        public void Delete(Guid id)
        {
            _toolRepository.Delete(id);
        }

        public ToolResponseDto GetById(Guid id)
        {
            var tool = _toolRepository.GetById(id);
            var response = _mapper.Map<ToolResponseDto>(tool);

            return response;
        }

        public ToolResponseDto Update(Guid id, ToolCreationRequestDto request)
        {
            var tool = _toolRepository.GetById(id);
            if (tool is null)
            {
                throw new AppException("Tool with provided id does not exist");
            }

            var toolUpdateRequest = _mapper.Map<Tool>(request);
            toolUpdateRequest.Id = id;
            var updatedTool = _toolRepository.Update(toolUpdateRequest);

            var response = _mapper.Map<ToolResponseDto>(updatedTool);

            return response;
        }
    }

}

using AutoMapper;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Responses;

namespace ToolManagementSystem.Core.Services;

public class AircraftService : IAircraftService
{
    private readonly IAircraftRepository _aircraftRepository;
    private readonly IMapper _mapper;

    public AircraftService(IAircraftRepository aircraftRepository, IMapper mapper)
    {
        _aircraftRepository = aircraftRepository;
        _mapper = mapper;
    }

    public IEnumerable<AircraftResponseDto> GetAll()
    {
        var aircrafts = _aircraftRepository.GetAll();
        var aircraftDtoList = aircrafts.Select(aircraft => _mapper.Map<AircraftResponseDto>(aircraft));
        return aircraftDtoList;
    }
}

using AutoMapper;
using ToolManagementSystem.Core.Helpers;
using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Core.Requests;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

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

    public AircraftResponseDto Create(AircraftRequestDto request)
    {
        var requestAircraft = _mapper.Map<Aircraft>(request);
        var createdAircraft = _aircraftRepository.Create(requestAircraft);
        var response = _mapper.Map<AircraftResponseDto>(createdAircraft);

        return response;
    }

    public void Delete(Guid id)
    {
        _aircraftRepository.Delete(id);
    }

    public AircraftResponseDto GetById(Guid id)
    {
        var aircraft = _aircraftRepository.GetById(id);
        var response = _mapper.Map<AircraftResponseDto>(aircraft);

        return response;
    }

    public AircraftResponseDto Update(Guid id, AircraftRequestDto request)
    {
        var aircraft = _aircraftRepository.GetById(id);
        if (aircraft is null)
        {
            throw new AppException("Aircraft with provided id does not exist");
        }

        var aircraftUpdateRequest = _mapper.Map<Aircraft>(request);
        aircraftUpdateRequest.Id = id;
        var updatedAircraft = _aircraftRepository.Update(aircraftUpdateRequest);
        var response = _mapper.Map<AircraftResponseDto>(updatedAircraft);

        return response;
    }
}

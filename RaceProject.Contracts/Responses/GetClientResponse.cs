using RaceProject.Contracts.Dtos;

namespace RaceProjcet.Contracts.Responses
{
    public record GetClientResponse(List<ClientDto> ClientDtos)
    {
        
    }
}
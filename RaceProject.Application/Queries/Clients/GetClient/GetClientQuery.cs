using MediatR;
using RaceProjcet.Contracts.Responses;

namespace RaceProject.Application.Queries.Clients.GetClient
{
    public record GetClientQuery() : IRequest<GetClientResponse>;
  
}
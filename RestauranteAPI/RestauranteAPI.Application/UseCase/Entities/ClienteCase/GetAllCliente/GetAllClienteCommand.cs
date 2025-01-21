using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetAll
{
    public record GetAllClienteCommand() : IRequest<IQueryable<ClienteResponseDTO>>;
}
using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetById
{
    public record GetByIdClienteCommand(Guid Id) : IRequest<IQueryable<ClienteResponseDTO>>
    {
    }
}
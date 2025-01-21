using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetById
{
    public record GetByIdPedidoCommand(Guid Id) : IRequest<IQueryable<PedidoResponseDTO>>
    {
    }
}
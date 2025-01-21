using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetAll
{
    public record GetAllPedidoCommand() : IRequest<IQueryable<PedidoResponseDTO>>;
}
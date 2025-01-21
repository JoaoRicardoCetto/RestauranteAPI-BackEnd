using RestauranteAPI.Application.DTOs.Common;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Delete
{
    public record DeletePedidoCommand(Guid Id) : IRequest<ApiResponse>
    {
    }
}
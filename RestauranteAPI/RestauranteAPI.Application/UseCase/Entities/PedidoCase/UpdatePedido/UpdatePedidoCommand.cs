using RestauranteAPI.Application.DTOs.Common;
using MediatR;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Update
{
    public record UpdatePedidoCommand(
      Guid Id,
      DateTimeOffset Data,
      decimal Valor,
      Guid PedidoClienteId,
      Guid ClienteId
    ) : IRequest<ApiResponse>;
}
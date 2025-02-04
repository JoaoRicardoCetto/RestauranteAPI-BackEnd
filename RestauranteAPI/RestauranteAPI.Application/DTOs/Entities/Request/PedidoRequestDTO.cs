using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;
using MediatR;

namespace RestauranteAPI.Application.DTOs.Entities.Request
{
    // DTO para requisições relacionadas a pedidos.
    public class PedidoRequestDTO : IRequest<ApiResponse>
    {
        public Guid Id {get; set;}
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }

    }
}

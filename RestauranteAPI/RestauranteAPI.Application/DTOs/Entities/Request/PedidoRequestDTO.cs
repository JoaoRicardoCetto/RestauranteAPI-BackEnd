using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;
using MediatR;

namespace RestauranteAPI.Application.DTOs.Entities.Request
{
    public class PedidoRequestDTO : IRequest<ApiResponse>
    {
        public Guid Id {get; set;}
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }

    }
}

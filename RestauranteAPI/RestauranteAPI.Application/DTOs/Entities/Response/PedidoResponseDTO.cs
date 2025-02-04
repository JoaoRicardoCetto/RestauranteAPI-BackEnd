using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Entities.Response
{
    //S�o os dados de Pedido que s�o enviados de volta para o front
    public class PedidoResponseDTO : BaseDTO
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }
        public virtual ClienteResponseDTO Cliente { get; set; }

    }
}

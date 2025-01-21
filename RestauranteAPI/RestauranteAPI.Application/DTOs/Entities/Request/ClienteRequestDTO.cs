using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;
using MediatR;

namespace RestauranteAPI.Application.DTOs.Entities.Request
{
    public class ClienteRequestDTO : IRequest<ApiResponse>
    {
        public Guid Id {get; set;}
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public String Identification { get; set; }
        public Guid ClienteCidadeId { get; set; }

    }
}

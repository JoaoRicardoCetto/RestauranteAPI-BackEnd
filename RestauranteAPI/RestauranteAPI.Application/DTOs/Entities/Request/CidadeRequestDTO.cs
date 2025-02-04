using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Enums;
using MediatR;

namespace RestauranteAPI.Application.DTOs.Entities.Request
{
    // DTO para requisições relacionadas a cidades.
    public class CidadeRequestDTO : IRequest<ApiResponse>
    {
        public Guid Id {get; set;}
        public string Nome { get; set; }



    }
}

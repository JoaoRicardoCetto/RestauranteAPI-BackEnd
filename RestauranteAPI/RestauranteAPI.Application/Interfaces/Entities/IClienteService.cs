using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces.Entities
{
    public interface IClienteService : IBaseService<ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
    }
}

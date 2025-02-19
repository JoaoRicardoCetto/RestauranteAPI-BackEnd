using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces.Entities
{
    // Interface para o servi�o de clientes, seguindo a estrutura do IBaseService.
    //Por ser um crud simples, n�o foi necess�ria a implementa��o de m�todos nessa interface
    public interface IClienteService : IBaseService<ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
    }
}

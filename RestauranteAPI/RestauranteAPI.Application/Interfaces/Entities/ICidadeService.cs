using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces.Entities
{
    // Interface para o serviço de cidades, seguindo a estrutura do IBaseService.
    //Por ser um crud simples, não foi necessária a implementação de métodos nessa interface
    public interface ICidadeService : IBaseService<CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
    }
}

using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetAll
{
    public class GetAllCidadeHandler : GetAllHandler<ICidadeService, GetAllCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public GetAllCidadeHandler(ICidadeService service) : base(service)
        {
        }
    }
}
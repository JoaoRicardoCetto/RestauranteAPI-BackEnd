using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetById
{
    internal class GetByIdCidadeHandler : GetByIdHandler<ICidadeService, GetByIdCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public GetByIdCidadeHandler(ICidadeService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
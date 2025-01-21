using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.Create
{
    public class CreateCidadeHandler : CreateHandler<ICidadeService, CreateCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public CreateCidadeHandler(IUnitOfWork unitOfWork, ICidadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
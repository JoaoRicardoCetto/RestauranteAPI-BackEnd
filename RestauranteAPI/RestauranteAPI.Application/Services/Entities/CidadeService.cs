using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Application.Services.Entities
{
    // Servi�o respons�vel por opera��es relacionadas � entidade Cidade.
    public class CidadeService :
        BaseService<
            CidadeRequestDTO,
            CidadeResponseDTO,
            Cidade,
            ICidadeRepository>, ICidadeService
    {

        // Construtor do servi�o CidadeService, inicializa as depend�ncias.
        public CidadeService(IMediator mediator, IMapper mapper, ICidadeRepository repository) : base(mediator, mapper, repository) { }

    }
}

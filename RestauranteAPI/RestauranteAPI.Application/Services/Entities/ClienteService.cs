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
    // Serviço responsável por operações relacionadas à entidade Cliente.
    public class ClienteService :
        BaseService<
            ClienteRequestDTO,
            ClienteResponseDTO,
            Cliente,
            IClienteRepository>, IClienteService
    {
        // Construtor do serviço ClienteService, inicializa as dependências.
        public ClienteService(IMediator mediator, IMapper mapper, IClienteRepository repository) : base(mediator, mapper, repository) { }

    }
}

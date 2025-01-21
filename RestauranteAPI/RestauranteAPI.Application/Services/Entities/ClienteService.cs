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
    public class ClienteService :
        BaseService<
            ClienteRequestDTO,
            ClienteResponseDTO,
            Cliente,
            IClienteRepository>, IClienteService
    {

        public ClienteService(IMediator mediator, IMapper mapper, IClienteRepository repository) : base(mediator, mapper, repository) { }

    }
}

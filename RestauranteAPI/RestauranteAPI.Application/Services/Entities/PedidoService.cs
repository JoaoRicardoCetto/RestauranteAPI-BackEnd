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
    public class PedidoService :
        BaseService<
            PedidoRequestDTO,
            PedidoResponseDTO,
            Pedido,
            IPedidoRepository>, IPedidoService
    {

        public PedidoService(IMediator mediator, IMapper mapper, IPedidoRepository repository) : base(mediator, mapper, repository) { }

    }
}

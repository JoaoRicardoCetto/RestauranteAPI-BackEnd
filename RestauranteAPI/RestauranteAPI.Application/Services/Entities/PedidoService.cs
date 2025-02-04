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
    // Serviço responsável por operações relacionadas à entidade Pedido.
    public class PedidoService :
        BaseService<
            PedidoRequestDTO,
            PedidoResponseDTO,
            Pedido,
            IPedidoRepository>, IPedidoService
    {
        // Construtor do serviço PedidoService, inicializa as dependências.
        public PedidoService(IMediator mediator, IMapper mapper, IPedidoRepository repository) : base(mediator, mapper, repository) { }

    }
}

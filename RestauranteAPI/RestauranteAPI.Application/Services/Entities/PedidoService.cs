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
    // Servi�o respons�vel por opera��es relacionadas � entidade Pedido.
    public class PedidoService :
        BaseService<
            PedidoRequestDTO,
            PedidoResponseDTO,
            Pedido,
            IPedidoRepository>, IPedidoService
    {
        // Construtor do servi�o PedidoService, inicializa as depend�ncias.
        public PedidoService(IMediator mediator, IMapper mapper, IPedidoRepository repository) : base(mediator, mapper, repository) { }

    }
}

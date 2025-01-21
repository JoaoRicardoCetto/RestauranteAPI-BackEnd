using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetById
{
    internal class GetByIdPedidoHandler : GetByIdHandler<IPedidoService, GetByIdPedidoCommand, PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
        public GetByIdPedidoHandler(IPedidoService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
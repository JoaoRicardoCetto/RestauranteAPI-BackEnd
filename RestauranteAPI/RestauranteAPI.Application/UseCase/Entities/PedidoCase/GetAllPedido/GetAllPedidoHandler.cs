using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetAll
{
    public class GetAllPedidoHandler : GetAllHandler<IPedidoService, GetAllPedidoCommand, PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
        public GetAllPedidoHandler(IPedidoService service) : base(service)
        {
        }
    }
}
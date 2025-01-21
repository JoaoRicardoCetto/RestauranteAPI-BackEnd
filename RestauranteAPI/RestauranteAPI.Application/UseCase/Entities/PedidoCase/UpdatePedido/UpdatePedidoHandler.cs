using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Update
{
    public class UpdatePedidoHandler : UpdateHandler<IPedidoService, UpdatePedidoCommand, PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
        public UpdatePedidoHandler(IUnitOfWork unitOfWork, IPedidoService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}
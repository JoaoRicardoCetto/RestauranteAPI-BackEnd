using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Delete
{
    public class DeletePedidoHandler : DeleteHandler<IPedidoService, DeletePedidoCommand, PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
        public DeletePedidoHandler(IUnitOfWork unitOfWork, IPedidoService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
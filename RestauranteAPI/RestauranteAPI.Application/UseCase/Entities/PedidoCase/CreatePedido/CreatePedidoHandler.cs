using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Create
{
    public class CreatePedidoHandler : CreateHandler<IPedidoService, CreatePedidoCommand, PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
        public CreatePedidoHandler(IUnitOfWork unitOfWork, IPedidoService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
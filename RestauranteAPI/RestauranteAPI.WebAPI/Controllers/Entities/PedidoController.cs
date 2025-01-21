using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Create;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetAll;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.PedidoCase.Update;
using RestauranteAPI.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteAPI.WebApi.Controllers.Entities
{
    [Route("api/Pedido")]
    [ApiController]
    public class PedidoController : BaseController
        <GetAllPedidoCommand,
        GetByIdPedidoCommand,
        CreatePedidoCommand,
        UpdatePedidoCommand,
        DeletePedidoCommand,
        PedidoResponseDTO>
    {
        public PedidoController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
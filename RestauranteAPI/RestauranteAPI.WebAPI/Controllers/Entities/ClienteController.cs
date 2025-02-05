using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Create;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetAll;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.ClienteCase.Update;
using RestauranteAPI.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteAPI.WebApi.Controllers.Entities
{
    [Route("api/Cliente")] //Definição da Rota 
    [ApiController]
    public class ClienteController : BaseController
        <GetAllClienteCommand,
        GetByIdClienteCommand,
        CreateClienteCommand,
        UpdateClienteCommand,
        DeleteClienteCommand,
        ClienteResponseDTO>
    {
        public ClienteController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
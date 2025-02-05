using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Create;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Delete;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetAll;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetById;
using RestauranteAPI.Application.UseCase.Entities.CidadeCase.Update;
using RestauranteAPI.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RestauranteAPI.WebApi.Controllers.Entities
{
    [Route("api/Cidade")] //Definição da Rota 
    [ApiController]
    public class CidadeController : BaseController
        <GetAllCidadeCommand,
        GetByIdCidadeCommand,
        CreateCidadeCommand,
        UpdateCidadeCommand,
        DeleteCidadeCommand,
        CidadeResponseDTO>
    {
        public CidadeController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
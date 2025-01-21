using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetById
{
    internal class GetByIdClienteHandler : GetByIdHandler<IClienteService, GetByIdClienteCommand, ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
        public GetByIdClienteHandler(IClienteService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
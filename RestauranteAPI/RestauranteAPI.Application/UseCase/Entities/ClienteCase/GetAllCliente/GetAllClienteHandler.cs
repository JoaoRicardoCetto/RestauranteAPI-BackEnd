using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetAll
{
    public class GetAllClienteHandler : GetAllHandler<IClienteService, GetAllClienteCommand, ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
        public GetAllClienteHandler(IClienteService service) : base(service)
        {
        }
    }
}
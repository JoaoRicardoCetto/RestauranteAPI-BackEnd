using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.Update
{
    public class UpdateClienteHandler : UpdateHandler<IClienteService, UpdateClienteCommand, ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
        public UpdateClienteHandler(IUnitOfWork unitOfWork, IClienteService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}
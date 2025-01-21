using AutoMapper;
using RestauranteAPI.Application.DTOs.Entities.Request;
using RestauranteAPI.Application.DTOs.Entities.Response;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.UseCase.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.Delete
{
    public class DeleteClienteHandler : DeleteHandler<IClienteService, DeleteClienteCommand, ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
        public DeleteClienteHandler(IUnitOfWork unitOfWork, IClienteService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
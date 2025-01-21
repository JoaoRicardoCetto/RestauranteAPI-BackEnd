using RestauranteAPI.Application.DTOs.Common;
using MediatR;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.Update
{
    public record UpdateClienteCommand(
      Guid Id,
      string Nome,
      string Telefone,
      String Identification,
      Guid ClienteCidadeId,


      Guid CidadeId
    ) : IRequest<ApiResponse>;
}
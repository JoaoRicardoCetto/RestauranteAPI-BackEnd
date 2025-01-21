using RestauranteAPI.Application.DTOs.Common;
using MediatR;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.Update
{
    public record UpdateCidadeCommand(
      Guid Id,
      string Nome
    ) : IRequest<ApiResponse>;
}
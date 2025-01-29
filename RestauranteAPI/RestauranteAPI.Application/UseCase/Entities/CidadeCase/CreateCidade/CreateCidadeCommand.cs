using RestauranteAPI.Application.DTOs.Common;
using MediatR;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.Create
{

    public record CreateCidadeCommand(
      string? Nome
    ) : IRequest<ApiResponse>;
}

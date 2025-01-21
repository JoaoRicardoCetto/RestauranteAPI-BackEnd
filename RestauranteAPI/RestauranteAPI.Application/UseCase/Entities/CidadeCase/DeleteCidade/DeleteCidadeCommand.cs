using RestauranteAPI.Application.DTOs.Common;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.Delete
{
    public record DeleteCidadeCommand(Guid Id) : IRequest<ApiResponse>
    {
    }
}
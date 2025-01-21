using RestauranteAPI.Application.DTOs.Common;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.Delete
{
    public record DeleteClienteCommand(Guid Id) : IRequest<ApiResponse>
    {
    }
}
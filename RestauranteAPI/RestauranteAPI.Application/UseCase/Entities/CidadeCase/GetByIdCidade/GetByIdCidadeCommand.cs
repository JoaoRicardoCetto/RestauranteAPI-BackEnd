using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetById
{
    public record GetByIdCidadeCommand(Guid Id) : IRequest<IQueryable<CidadeResponseDTO>>
    {
    }
}
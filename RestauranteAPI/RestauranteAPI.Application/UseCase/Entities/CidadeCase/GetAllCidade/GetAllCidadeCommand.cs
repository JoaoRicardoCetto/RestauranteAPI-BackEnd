using RestauranteAPI.Application.DTOs.Entities.Response;
using MediatR;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetAll
{
    public record GetAllCidadeCommand() : IRequest<IQueryable<CidadeResponseDTO>>;
}
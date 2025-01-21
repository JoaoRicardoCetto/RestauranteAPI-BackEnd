using MediatR;

namespace RestauranteAPI.Application.Security.Account.UseCases.SaveRefreshToken
{
    public record Request(
        Guid Id,
        Guid? RefreshToken
    ) : IRequest<Response>;
}
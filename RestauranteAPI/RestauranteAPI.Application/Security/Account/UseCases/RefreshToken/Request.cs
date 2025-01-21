using MediatR;
using RestauranteAPI.Application.Security.Account.UseCases.Authenticate;

namespace RestauranteAPI.Application.Security.Account.UseCases.RefreshToken
{
    public record Request(
        Guid RefreshToken
    ) : IRequest<Response>;
}
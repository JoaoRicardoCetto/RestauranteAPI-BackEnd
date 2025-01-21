using MediatR;

namespace RestauranteAPI.Application.Security.Account.UseCases.Authenticate
{

    public record Request(
        string Email,
        string Password
    ) : IRequest<Response>;
}
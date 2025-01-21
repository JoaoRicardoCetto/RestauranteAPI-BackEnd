using MediatR;

namespace RestauranteAPI.Application.Security.Account.UseCases.ChangePassword
{
    public record class Request
    (
        string Code,
        string Password
    ) : IRequest<Response>;
}
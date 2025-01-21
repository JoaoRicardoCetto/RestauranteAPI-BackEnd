using MediatR;

namespace RestauranteAPI.Application.Security.Account.UseCases.SendResetPassword
{
    public record class Request(
        string Email
    ) : IRequest<Response>;
}
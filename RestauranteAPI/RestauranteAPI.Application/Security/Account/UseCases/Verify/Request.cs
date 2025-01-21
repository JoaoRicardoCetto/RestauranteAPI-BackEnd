using MediatR;
using RestauranteAPI.Application.Security.Account.UseCases.Authenticate;

namespace RestauranteAPI.Application.Security.Account.UseCases.Verify
{
    public record Request(string Code) : IRequest<Response>;
}
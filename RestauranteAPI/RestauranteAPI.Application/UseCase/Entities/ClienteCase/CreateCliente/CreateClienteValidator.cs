using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.Create
{
    public class CreateClienteValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteValidator()
        {
        }
    }
}
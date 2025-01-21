using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.ClienteCase.GetAll
{
    public class GetAllClienteValidator : AbstractValidator<GetAllClienteCommand>
    {
        public GetAllClienteValidator()
        {
        }
    }
}
using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.Create
{
    public class CreateCidadeValidator : AbstractValidator<CreateCidadeCommand>
    {
        public CreateCidadeValidator()
        {
        }
    }
}
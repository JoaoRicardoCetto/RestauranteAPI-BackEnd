using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.CidadeCase.GetAll
{
    public class GetAllCidadeValidator : AbstractValidator<GetAllCidadeCommand>
    {
        public GetAllCidadeValidator()
        {
        }
    }
}
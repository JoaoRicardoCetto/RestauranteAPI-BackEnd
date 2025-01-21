using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.Create
{
    public class CreatePedidoValidator : AbstractValidator<CreatePedidoCommand>
    {
        public CreatePedidoValidator()
        {
        }
    }
}
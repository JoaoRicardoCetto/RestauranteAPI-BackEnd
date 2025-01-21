using FluentValidation;

namespace RestauranteAPI.Application.UseCase.Entities.PedidoCase.GetAll
{
    public class GetAllPedidoValidator : AbstractValidator<GetAllPedidoCommand>
    {
        public GetAllPedidoValidator()
        {
        }
    }
}
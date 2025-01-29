using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Domain.Interfaces.Entities
{
    //Neste caso, por ser um crud simples, essa interface está vazia,
    public interface ICidadeRepository : IBaseRepository<Cidade>
    {
    }
}

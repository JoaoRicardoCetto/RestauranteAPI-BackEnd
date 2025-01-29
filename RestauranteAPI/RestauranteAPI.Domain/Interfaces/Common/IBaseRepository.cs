using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Domain.Interfaces.Common
{
    //IBaseRepository � uma interface que possui os m�todos de comunica��o com o banco de dados

    //A interface recebe um T gen�rico, por�m esse T deve herdar de BaseEntity
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<bool> Any(Guid id);
        /*IQueryable � uma estrutura de query do C# que monta uma query, uma estrutura que
        consegue buscar a informa��o pra voc�, para conseguir essa informa��o � necess�rio um m�todo como .ToList()*/
        IQueryable<T> GetById(Guid id);
        IQueryable<T> GetAll();
        void AddRange(ICollection<T> entities);
        void DeleteRange(ICollection<T> entities);
    }
}

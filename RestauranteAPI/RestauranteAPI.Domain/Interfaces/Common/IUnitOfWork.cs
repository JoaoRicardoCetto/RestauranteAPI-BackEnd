namespace RestauranteAPI.Domain.Interfaces.Common
{
    /*IUnitOfWork é responsável pelas alterações no banco. Uma explicação mais
    detalhada se encontra na implementação da interface, na classe UnitOfWork na camada Infrastructure */
     
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}

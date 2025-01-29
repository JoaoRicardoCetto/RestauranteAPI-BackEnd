namespace RestauranteAPI.Domain.Interfaces.Common
{
    /*IUnitOfWork � respons�vel pelas altera��es no banco. Uma explica��o mais
    detalhada se encontra na implementa��o da interface, na classe UnitOfWork na camada Infrastructure */
     
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}

using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Repositories
{
    /*UnitOfWork � respons�vel pelas altera��es no banco. Quando um create, update, delete � executado,
    essas altera��es ainda n�o foram enviadas ao banco, para evitar conflitos em m�todos async, por exemplo,
    nenhuma dessas altera��es s�o feitas, elas s�o "guardadas" e no final do c�digo � executado o commit do UnitOfWork,
    onde ele faz todas essas altera��es de uma vez, isso evita acessos desnecess�rios ao banco*/
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context; //Contexto do banco de dados

        public UnitOfWork(AppDbContext context) 
        {
            _context = context;
        }

        /// Confirma as altera��es realizadas no contexto e salva no banco de dados.
        public async Task Commit(CancellationToken cancellationToken) //Token para cancelamento da opera��o ass�ncrona
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

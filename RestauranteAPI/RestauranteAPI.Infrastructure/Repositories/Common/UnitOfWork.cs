using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Repositories
{
    /*UnitOfWork é responsável pelas alterações no banco. Quando um create, update, delete é executado,
    essas alterações ainda não foram enviadas ao banco, para evitar conflitos em métodos async, por exemplo,
    nenhuma dessas alterações são feitas, elas são "guardadas" e no final do código é executado o commit do UnitOfWork,
    onde ele faz todas essas alterações de uma vez, isso evita acessos desnecessários ao banco*/
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task Commit(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

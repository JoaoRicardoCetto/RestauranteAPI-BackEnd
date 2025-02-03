using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace RestauranteAPI.Infrastructure.Repositories.Common
{
    //Implementa��o dos m�todos de altera��o do banco

    //<T> Deve herdar de BaseEntity
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
            DbSet =  Context.Set<T>();
        }

        //Adiciona uma entidade no Banco de Dados de forma ass�ncrona
        public async Task Create(T entity)
        {
            await Context.AddAsync(entity);
        }

        public async Task Delete(T entity)
        {
            entity.Delete();
            /*O m�todo Context.Remove(entity) n�o � um m�todo async, por�m nosso Delete �. Por isso criamos uma task. 
            A CancellationToken passada como par�metro caso o m�todo tenha que ser cancelado em meio a seu processo. */
            await Task.Run(() => Context.Remove(entity), new CancellationToken());
        }
        public async Task Update(T entity)
        {
            //Mesmo caso do Delete
            await Task.Run(() => Context.Update(entity), new CancellationToken());
        }

        // Retorna todas as entidades do tipo T
        public IQueryable<T> GetAll()
        {
            // O m�todo AsSplitQuery melhora o desempenho em consultas complexas. O .AsQueryable transforma a requisi��o em uma Query
            return Context.Set<T>()
                 .AsSplitQuery().AsQueryable(); 
        }

        public IQueryable<T> GetById(Guid id)
        {
            /* .AsNoTracking() instrui o Entity Framework a n�o rastrear as entidades retornadas. Isso melhora a performance
            quando os dados ser�o apenas lidos e n�o modificados.*/
            return Context.Set<T>().Where(x => x.Id == id).AsNoTracking().AsQueryable();
        }

        // Verifica se existe alguma entidade com o ID especificado no banco de dados.
        public async Task<bool> Any(Guid id)
        {
            return await Context.Set<T>().AnyAsync(x => x.Id.Equals(id));
        }

        // Remove um conjunto de entidades do banco de dados.
        public void DeleteRange(ICollection<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        // Adiciona um conjunto de entidades ao banco de dados.
        public void AddRange(ICollection<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }
    }
}

using RestauranteAPI.Domain.Interfaces.Security;
using RestauranteAPI.Domain.Security.Shared.Entities;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Security.Repositories
{
    public class BaseSecurityRepository<T> : IBaseSecurityRepository<T> where T : Entity
    {
        protected readonly AppDbContext Context;

        public BaseSecurityRepository(AppDbContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            Context.Add(entity);
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public IQueryable<T> GetById(Guid id)
        {
            return Context.Set<T>().Where(x => x.Id == id).AsQueryable();
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().ToList().AsQueryable();
        }
    }
}

using MediatR;
using RestauranteAPI.Domain.Interfaces.Security;
using RestauranteAPI.Domain.Security.Shared.Entities;

namespace RestauranteAPI.Application.Security.Services
{
    public class BaseSecurityService<Repository> : IBaseSecurityRepository<Entity>
        where Repository : IBaseSecurityRepository<Entity>
    {
        private readonly IMediator _mediator;
        private readonly Repository _repository;

        public BaseSecurityService(IMediator mediator, Repository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public void Create(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}

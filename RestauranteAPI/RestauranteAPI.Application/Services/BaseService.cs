using AutoMapper;
using AutoMapper.QueryableExtensions;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace RestauranteAPI.Application.Services
{
    // Serviço base genérico para operações CRUD
    public class BaseService<Request, Response, Entity, Repository> : IBaseService<Request, Response, Entity>
       where Entity : BaseEntity
       where Response : BaseDTO
       where Repository : IBaseRepository<Entity>
    {
        protected readonly IMediator _mediator; //Mediator para manipulação de eventos
        protected readonly IMapper _mapper; //Mapper para conversão entre entidades e DTOs
        protected readonly Repository _repository; //Repository para acesso ao Banco

        public BaseService(IMediator mediator, IMapper mapper, Repository repository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _repository = repository;
        }

        //retorna uma coleção de entidades convertidas para DTOs
        public virtual async Task<IQueryable<Response>> GetAll()
        {
            var result = _repository.GetAll();
            var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider); 
            return response;
        }

        // Retorna uma entidade convertida para DTO
        public virtual async Task<IQueryable<Response>> GetById(Guid id)
        {
            var result = _repository.GetById(id);
            var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider);
            return response;
        }

        public virtual async Task<ApiResponse> Create(Request request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);
            await _repository.Create(entity); //Create no banco de dados

            //Resposta da API indicando que o item foi criado com sucesso, em caso de falha, esse retorno não é executado
            return new ApiResponse(201, entity.Id.ToString(), "item criado com sucesso!");
        }

        public virtual async Task<ApiResponse> Delete(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetById(id).FirstOrDefaultAsync();
            await _repository.Delete(entity); //Delete no bando de dados

            //Resposta da API indicando sucesso, em caso de falha, esse retorno não é executado
            return new ApiResponse(200, "item deletado com sucesso!");
        }

        public virtual async Task<ApiResponse> Update(Request request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);

            var result = await _repository.GetById(entity.Id).FirstOrDefaultAsync();
            result.Update(entity); //Update da entidade

            await _repository.Update(result); //Update no banco de dados

            //Resposta da API indicando sucesso, em caso de falha, esse retorno não é executado
            return new ApiResponse(200, result.Id.ToString(), "item atualizado com sucesso!");
        }

        //Realiza uma série de verificações para confirmar se a entidade pode ser salva
        public virtual List<string> SaveValidation()
        {
            return [];

        }
    }
}

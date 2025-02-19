using AutoMapper;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Common;
using MediatR;

namespace RestauranteAPI.Application.UseCase.BaseCase
{
    public class GetByIdHandler<IService, GetRequest, Request, Response, Entity> : IRequestHandler<GetRequest, IQueryable<Response>>
        where Entity : BaseEntity
        where Response : BaseDTO
        where GetRequest : IRequest<IQueryable<Response>>
        where Request : IRequest<ApiResponse>
        where IService : IBaseService<Request, Response, Entity>
    {

        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public GetByIdHandler(IService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IQueryable<Response>> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);
            return await _service.GetById(entity.Id);
        }
    }
}
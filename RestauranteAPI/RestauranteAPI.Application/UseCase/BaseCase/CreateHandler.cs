using AutoMapper;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using MediatR;

namespace RestauranteAPI.Application.UseCase.BaseCase
{
    //Handlers servem como uma camada de abstração, sempre que receber um command, ele envia pro método específico em seu Service respectivo. A Entidade então é passada para o mediator e em sua lista de commands, ele entende para onde enviar essa entidade
    //Portanto, não é necessário que o CidadeController saiba sobre o CidadeService, ele só precisa enviar para o mediator

    //<IService (Usado no Handler), Command do Request, >
    public class CreateHandler<IService, CreateRequest, Request, Response, Entity> : IRequestHandler<CreateRequest, ApiResponse>
        where Entity : BaseEntity
        where Response : BaseDTO
        where CreateRequest : IRequest<ApiResponse>
        where Request : IRequest<ApiResponse>
        where IService : IBaseService<Request, Response, Entity>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public CreateHandler(IUnitOfWork unitOfWork, IService service, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(CreateRequest createRequest, CancellationToken cancellationToken)
        {
            var request = _mapper.Map<Request>(createRequest);
            var response = await _service.Create(request, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);
            return response;
        }
    }
}
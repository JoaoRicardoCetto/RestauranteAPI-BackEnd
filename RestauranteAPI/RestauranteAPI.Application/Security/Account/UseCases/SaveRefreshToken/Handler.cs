using MediatR;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Domain.Interfaces.Security;
using RestauranteAPI.Domain.Security.Account.Entities;


namespace RestauranteAPI.Application.Security.Account.UseCases.SaveRefreshToken
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Handler(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            User? user;

            #region Validar Requisição
            try
            {
                var res = Specification.Ensure(request);
                if (!res.IsValid) return new Response("Requisição inválida", 400, res.Notifications);
            }
            catch
            {
                return new Response("Não foi possível validar a sua requisição", 500);
            }
            #endregion

            #region Buscar usuário no banco
            try
            {
                user = _repository.GetById(request.Id).Single();
                if (user == null)
                {
                    return new Response("Usuário não encontrado", 404);
                }
            }
            catch (Exception e)
            {
                return new Response("Não foi possível validar a sua requisição", 500);
            }
            #endregion

            #region Salva o Refresh Token no banco
            try
            {
                user.UpdateRefreshToken(request.RefreshToken);
            }
            catch (Exception e)
            {
                return new Response(e.Message, 500);
            }
            #endregion

            await _unitOfWork.Commit(cancellationToken);

            return new Response("Refresh Token salvo com sucesso", new ResponseData(user.Id, user.Name, user.Email.Address));
        }
    }
}
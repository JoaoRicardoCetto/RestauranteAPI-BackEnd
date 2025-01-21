using MediatR;
using RestauranteAPI.Application.Security.Interfaces;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Domain.Interfaces.Security;
using RestauranteAPI.Domain.Security.Account.Entities;
using RestauranteAPI.Domain.Security.Account.ValueObjects;

namespace RestauranteAPI.Application.Security.Account.UseCases.Create
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        private readonly IService _service;
        private readonly IUnitOfWork _unitOfWork;

        public Handler(IUserRepository userRepository, IRoleRepository roleRepository, IService service, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _service = service;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> Handle(
            Request request,
            CancellationToken cancelationToken)
        {
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

            #region Gerar os objetos
            Email email;
            Password password;
            User user;

            try
            {
                email = new Email(request.Email);
                password = new Password(request.Password);
                user = new User(request.Name, email, password);
            }
            catch (Exception ex)
            {
                return new Response(ex.Message, 400);
            }
            #endregion

            #region Verificar existência do usuário no banco
            try
            {
                var exists = await _userRepository.AnyAsync(request.Email, cancelationToken);

                if (exists)
                    return new Response("Este email já está em uso", 400);

            }
            catch
            {
                return new Response("Falha ao verificar o email cadastrado", 500);
            }
            #endregion

            #region Persistência os dados
            try
            {
                _userRepository.Create(user);
            }
            catch
            {
                return new Response("Falha ao persistir dados", 500);
            }
            #endregion

            #region Enviar email de ativação
            try
            {
                await _service.SendVerificationEmailAsync(user, cancelationToken);
            }
            catch
            {
                // faça nada
            }
            #endregion

            await _unitOfWork.Commit(cancelationToken);

            return new Response("Conta criada com sucesso", new ResponseData(user.Id, user.Name, user.Email.Address));
        }
    }
}
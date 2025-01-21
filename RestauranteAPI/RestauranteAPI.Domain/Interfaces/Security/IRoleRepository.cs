using RestauranteAPI.Domain.Security.Account.Entities;

namespace RestauranteAPI.Domain.Interfaces.Security
{
    public interface IRoleRepository : IBaseSecurityRepository<Role>
    {
        Task<Role> GetRoleByName(string name, CancellationToken cancelationToken);
    }
}

using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Interfaces.Security;
using RestauranteAPI.Domain.Security.Account.Entities;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Security.Repositories
{
    public class RoleRepository : BaseSecurityRepository<Role>, IRoleRepository
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Role> GetRoleByName(string name, CancellationToken cancelationToken)
        {
            return _context.Roles.FirstOrDefaultAsync(x => x.Name == name, cancellationToken: cancelationToken);
        }
    }
}

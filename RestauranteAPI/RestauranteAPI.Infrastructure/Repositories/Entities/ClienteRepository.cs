using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using RestauranteAPI.Domain.Interfaces.Entities;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Infrastructure.Repositories.Entities
{
    // Repositório responsável por operações relacionadas à entidade Cliente.
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context) { }

    }
}

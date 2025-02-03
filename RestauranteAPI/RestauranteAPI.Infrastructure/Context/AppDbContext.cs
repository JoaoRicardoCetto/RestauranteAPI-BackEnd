using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.Context
{
    //Adi��o de pacote NuGet (Gerenciar Pacotes NuGet -> Procurar "Microsoft.EntityFrameworkCore")
    //Refer�ncia de projeto com a Domain (Adicionar -> Referencia de projeto -> Adicionar a Infra)

    /* AppDbContext � o contexto do banco que permitir� altera��es no Bando de Dados, 
    ele "diz" a aplica��o como o banco funciona */
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}

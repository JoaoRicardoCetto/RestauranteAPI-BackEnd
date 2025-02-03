using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Domain.Interfaces.Entities;
using RestauranteAPI.Infrastructure.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace RestauranteAPI.Infrastructure
{
    //O serviceExtensions configura os servi�os de persist�ncia da aplica��o.
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            // Obt�m a string de conex�o do banco de dados a partir das vari�veis de ambiente.
            var connectionString = Environment.GetEnvironmentVariable("SqlServer");

            // Neste caso, estamos usando SQL Server, mas pode ser configurado para qualquer outro banco.
            //x.MigrationsAssembly() permite uma atualiza��o mais simples do banco de dados, algo parecido com um update comum, sem necessidade de deletar e recriar o banco.
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString, x => x.MigrationsAssembly("RestauranteAPI.Infrastructure")), ServiceLifetime.Scoped);

            // Adiciona o padr�o Unit of Work � inje��o de depend�ncia.
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Registra os reposit�rios espec�ficos no container de inje��o de depend�ncias.
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

        }
    }
}

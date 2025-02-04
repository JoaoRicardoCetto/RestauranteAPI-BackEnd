using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.Services.Entities;
using RestauranteAPI.Application.Shared.Behavior;
using System.Reflection;

namespace RestauranteAPI.Application.Services
{
    // Classe de extensão para configuração dos serviços da camada de aplicação.
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            // Adiciona AutoMapper para mapeamento de objetos entre diferentes camadas.
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Adiciona MediatR para implementação do padrão CQRS e comunicação entre handlers.
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            
            // Registra os validadores FluentValidation localizados no assembly atual.
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            // Adiciona um comportamento de pipeline para validações antes da execução de comandos MediatR.
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            // Registra os serviços de aplicação no container de injeção de dependências.
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IPedidoService, PedidoService>();

        }
    }
}
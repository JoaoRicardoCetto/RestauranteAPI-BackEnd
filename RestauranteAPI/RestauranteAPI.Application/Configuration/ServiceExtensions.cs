using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.Services.Entities;
using RestauranteAPI.Application.Shared.Behavior;
using System.Reflection;

namespace RestauranteAPI.Application.Services
{
    // Classe de extens�o para configura��o dos servi�os da camada de aplica��o.
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            // Adiciona AutoMapper para mapeamento de objetos entre diferentes camadas.
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Adiciona MediatR para implementa��o do padr�o CQRS e comunica��o entre handlers.
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            
            // Registra os validadores FluentValidation localizados no assembly atual.
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            // Adiciona um comportamento de pipeline para valida��es antes da execu��o de comandos MediatR.
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            // Registra os servi�os de aplica��o no container de inje��o de depend�ncias.
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IPedidoService, PedidoService>();

        }
    }
}
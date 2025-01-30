using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces.Entities;
using RestauranteAPI.Application.Services.Entities;
using RestauranteAPI.Application.Shared.Behavior;
using System.Reflection;

namespace RestauranteAPI.Application.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IPedidoService, PedidoService>();

        }
    }
}
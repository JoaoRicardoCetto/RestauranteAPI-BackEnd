using RestauranteAPI.Application.DTOs.Entities.Response;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace RestauranteAPI.WebApi.Extensions
{
    public static class ODataExtension
    {
        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new();
            builder.EntitySet<ClienteResponseDTO>("cliente");
            builder.EntitySet<CidadeResponseDTO>("cidade");
            builder.EntitySet<PedidoResponseDTO>("pedido");

            return builder.GetEdmModel();
        }

        public static void ODataConfiguration(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                // Add filter exceptions here
            })
            .AddOData(options => options
                .SkipToken()
                .AddRouteComponents("api", GetEdmModel()) // Adiciona OData na rota "api"
                .Select()  // Permite seleção de campos específicos
                .Filter()  // Permite filtragem de registros (ex: ?$filter=nome eq 'João')
                .OrderBy() // Permite ordenação (ex: ?$orderby=idade desc)
                .SetMaxTop(4) // Define um limite máximo de registros retornados
                .Count()   // Permite contar a quantidade total de registros
                .Expand()); // Permite expandir dados relacionados (ex: ?$expand=pedidos)
        }
    }
}
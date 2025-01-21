using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasMany<Pedido>(cliente => cliente.Pedidos)
                .WithOne(pedido => pedido.Cliente)
                .HasForeignKey(cliente => cliente.PedidoClienteId);



        }
    }
}

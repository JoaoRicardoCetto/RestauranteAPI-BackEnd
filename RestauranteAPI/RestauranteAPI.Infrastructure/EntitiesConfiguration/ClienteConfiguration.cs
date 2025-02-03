using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id); //Chave primária é o ID
            builder.HasIndex(x => x.Identification).IsUnique(); //Garante que o numero de identificação seja único
            builder
                .HasMany<Pedido>(cliente => cliente.Pedidos) //Cliente possui N Pedidos
                .WithOne(pedido => pedido.Cliente) //Pedido possui 1 Cliente
                .HasForeignKey(cliente => cliente.PedidoClienteId); //Possui chave estrangeira, PedidoClienteID



        }
    }
}

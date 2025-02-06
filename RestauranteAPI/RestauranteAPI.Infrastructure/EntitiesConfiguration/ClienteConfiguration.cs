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

            builder.Property(x => x.Identification)
                .IsRequired() // Campo obrigatório
                .HasMaxLength(11); // Define um tamanho máximo para o campo

            builder.Property(x => x.Nome)
                .IsRequired() // Campo obrigatório
                .HasMaxLength(100); // Define um tamanho máximo para o campo

            builder.Property(x => x.Telefone)
                .IsRequired() // Campo obrigatório
                .HasMaxLength(14); // Define um tamanho máximo para o campo

            builder
                .HasMany<Pedido>(cliente => cliente.Pedidos) //Cliente possui N Pedidos
                .WithOne(pedido => pedido.Cliente) //Pedido possui 1 Cliente
                .HasForeignKey(cliente => cliente.PedidoClienteId); //Possui chave estrangeira, PedidoClienteID
        }


    }
    
}

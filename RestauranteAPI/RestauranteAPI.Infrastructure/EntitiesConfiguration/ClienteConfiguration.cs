using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id); //Chave prim�ria � o ID
            builder.HasIndex(x => x.Identification).IsUnique(); //Garante que o numero de identifica��o seja �nico

            builder.Property(x => x.Identification)
                .IsRequired() // Campo obrigat�rio
                .HasMaxLength(11); // Define um tamanho m�ximo para o campo

            builder.Property(x => x.Nome)
                .IsRequired() // Campo obrigat�rio
                .HasMaxLength(100); // Define um tamanho m�ximo para o campo

            builder.Property(x => x.Telefone)
                .IsRequired() // Campo obrigat�rio
                .HasMaxLength(14); // Define um tamanho m�ximo para o campo

            builder
                .HasMany<Pedido>(cliente => cliente.Pedidos) //Cliente possui N Pedidos
                .WithOne(pedido => pedido.Cliente) //Pedido possui 1 Cliente
                .HasForeignKey(cliente => cliente.PedidoClienteId); //Possui chave estrangeira, PedidoClienteID
        }


    }
    
}

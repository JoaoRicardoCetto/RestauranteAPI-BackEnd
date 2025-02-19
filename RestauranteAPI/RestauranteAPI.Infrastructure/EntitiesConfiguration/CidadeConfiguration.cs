using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    //
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(x => x.Id); //Chave prim�ria � o ID
            builder.HasIndex(x => x.Nome).IsUnique();

            builder.Property(x => x.Nome)
                .IsRequired(); // Campo obrigat�rio

            builder
                .HasMany<Cliente>(cidade => cidade.Clientes) //Cidade possui N Clientes
                .WithOne(cliente => cliente.Cidade) //Cliente tem uma Cidade
                .HasForeignKey(cidade => cidade.ClienteCidadeId); //Possui chave estrangeira, ClienteCidadeID


        }
    }
}

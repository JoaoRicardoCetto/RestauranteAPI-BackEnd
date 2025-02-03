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
            builder.HasKey(x => x.Id); //Chave primária é o ID
            builder
                .HasMany<Cliente>(cidade => cidade.Clientes) //Cidade possui N Clientes
                .WithOne(cliente => cliente.Cidade) //Cliente tem uma Cidade
                .HasForeignKey(cidade => cidade.ClienteCidadeId); //Possui chave estrangeira, ClienteCidadeID


        }
    }
}

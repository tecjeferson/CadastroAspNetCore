using Cadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Data.Maps
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(230).HasColumnType("varchar(230)");
            builder.Property(x => x.Nacionalidade).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(x => x.CEP).HasMaxLength(9).HasColumnType("varchar(9)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(11).HasColumnType("varchar(11)");
            
                       
        }
  
        
    }
}
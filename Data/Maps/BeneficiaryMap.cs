using Cadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Data.Maps
{
    public class BeneficiaryMap  : IEntityTypeConfiguration<Beneficiary>
    {
        public void Configure(EntityTypeBuilder<Beneficiary> builder)
        {
            builder.ToTable("Beneficiary");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(11).HasColumnType("varchar(11)");
            builder.HasOne(x => x.Client).WithMany(x => x.Beneficiaries);
            
        }
    }
}
using Cadastro.Data.Maps;
using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=cadastro;User ID=SA;Password=1q2w3e%&");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientMap());
            builder.ApplyConfiguration(new BeneficiaryMap());
        }

    }
}
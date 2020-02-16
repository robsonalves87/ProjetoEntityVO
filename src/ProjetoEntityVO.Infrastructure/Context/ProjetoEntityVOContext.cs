using Microsoft.EntityFrameworkCore;
using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Infrastructure.Mappings;
using System;
using System.Configuration;
using System.Linq;

namespace ProjetoEntityVO.Infrastructure.Context
{
    public class ProjetoEntityVOContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaDoProduto> CategoriasProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ProjetoEntityVODataBase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaDoProdutoMap());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}

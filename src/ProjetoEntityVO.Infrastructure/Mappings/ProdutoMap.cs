using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEntityVO.Domain.Entities;

namespace ProjetoEntityVO.Infrastructure.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Id)
                .HasColumnName("Id");

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.Valor)
                .IsRequired();
        }
    }
}

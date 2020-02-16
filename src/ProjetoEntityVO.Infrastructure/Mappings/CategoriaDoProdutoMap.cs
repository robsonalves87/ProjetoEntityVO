using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEntityVO.Domain.Entities;

namespace ProjetoEntityVO.Infrastructure.Mappings
{
    public class CategoriaDoProdutoMap : IEntityTypeConfiguration<CategoriaDoProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaDoProduto> builder)
        {
            builder.Property(cp => cp.Id)
                .HasColumnName("Id");

            builder.Property(cp => cp.Nome)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(cp => cp.Descricao)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);
        }
    }
}

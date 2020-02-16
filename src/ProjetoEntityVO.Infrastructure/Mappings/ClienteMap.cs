using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEntityVO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEntityVO.Infrastructure.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.OwnsOne(c => c.Nome).Property(n => n.PrimeiroNome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.OwnsOne(c => c.Nome).Property(n => n.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Documento).Property(d => d.CPF)
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();

            builder.OwnsOne(c => c.Documento).Property(d => d.RG)
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();

            builder.OwnsOne(c => c.Email).Property(e => e.Endereco)
                .HasColumnName("Email")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.Logradouro)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.Numero)
                .HasColumnType("varchar(100)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.Complemento)
                .HasColumnType("varchar(200)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.Bairro)
                .HasColumnType("varchar(150)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.Cidade)
                .HasColumnType("varchar(150)")
                .HasMaxLength(250)
                .IsRequired();

            builder.OwnsOne(c => c.Endereco).Property(e => e.CEP)
                .HasColumnType("varchar(8)")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(c => c.DataNascimento)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}

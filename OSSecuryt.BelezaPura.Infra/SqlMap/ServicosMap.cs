using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSSecuryt.BelezaPura.Domain.Entity;
using System;

namespace OSSecuryt.BelezaPura.Infra.SqlMap
{
    public class ServicosMap : IEntityTypeConfiguration<Servicos>
    {
        public void Configure(EntityTypeBuilder<Servicos> builder)
        {
            builder.ToTable("TB_SERVICOS");

            builder.HasKey(servicos => servicos.Id);

            builder.Property(servicos => servicos.Id)
             .HasColumnName("ID");

            builder.Property(servicos => servicos.NomeServico)
              .HasColumnName("NOMESERVICO")
              .HasMaxLength(150)
              .HasColumnType("varchar")
              .IsRequired();

            builder.Property(servicos => servicos.ClienteNome)
            .HasColumnName("NOMECLIENTE")
            .HasMaxLength(150)
            .HasColumnType("varchar")
            .IsRequired();

            builder.Property(servicos => servicos.ClienteCelular)
            .HasColumnName("NOMECELULAR")
            .HasMaxLength(15)
            .HasColumnType("varchar")
            .IsRequired();
            builder.Property(servicos => servicos.DataServicos)
           .HasColumnName("SERVICO_DATA")
           .IsRequired();

            builder.Property(servicos => servicos.Tipo)
           .HasColumnName("TIPO")
           .HasMaxLength(50)
           .HasColumnType("varchar")
           .IsRequired();

            builder.Property(servicos => servicos.BodyPart)
            .HasColumnName("BODY_PART")
            .HasMaxLength(50)
            .HasColumnType("varchar")          
            .IsRequired();

            builder.Property(servicos => servicos.Valor)
            .HasColumnName("VALOR")
            .HasColumnType("decimal")
            .IsRequired();

            builder.Ignore(x => x.Errors);




        }
    }
}

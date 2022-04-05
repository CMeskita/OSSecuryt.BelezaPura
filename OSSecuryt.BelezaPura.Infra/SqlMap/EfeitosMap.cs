using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSSecuryt.BelezaPura.Domain.Entity;


namespace OSSecuryt.BelezaPura.Infra.SqlMap
{
    public class EfeitosMap : IEntityTypeConfiguration<Efeitos>
    {
        
        public void Configure(EntityTypeBuilder<Efeitos> builder)
        {
            builder.ToTable("TB_EFEITOS");
            builder.Property(efeitos => efeitos.Id)
               .HasColumnName("ID");

            builder.Property(efeitos => efeitos.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(150)
                    .HasColumnType("varchar")
                    .IsRequired();

            builder.Ignore(x => x.Errors);

        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSSecuryt.BelezaPura.Infra.Data.DbSqlServer;

namespace OSSecuryt.BelezaPura.Infra.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OSSecuryt.BelezaPura.Domain.Entity.Efeitos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("DESCRICAO");

                    b.HasKey("Id");

                    b.ToTable("TB_EFEITOS");
                });

            modelBuilder.Entity("OSSecuryt.BelezaPura.Domain.Entity.Servicos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("BodyPart")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("BODY_PART");

                    b.Property<string>("ClienteCelular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("NOMECELULAR");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<DateTime>("DataServicos")
                        .HasColumnType("datetime2")
                        .HasColumnName("SERVICO_DATA");

                    b.Property<Guid?>("EfeitosId")
                        .HasColumnType("uniqueidentifier");


                    b.Property<string>("NomeServico")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("NOMESERVICO");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TIPO");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("VALOR");

                    b.Property<double>("ValorTotalServico")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EfeitosId");

                    b.ToTable("TB_SERVICOS");
                });

            modelBuilder.Entity("OSSecuryt.BelezaPura.Domain.Entity.Servicos", b =>
                {
                    b.HasOne("OSSecuryt.BelezaPura.Domain.Entity.Efeitos", "Efeitos")
                        .WithMany("Servicos")
                        .HasForeignKey("EfeitosId");

                    b.Navigation("Efeitos");
                });

            modelBuilder.Entity("OSSecuryt.BelezaPura.Domain.Entity.Efeitos", b =>
                {
                    b.Navigation("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
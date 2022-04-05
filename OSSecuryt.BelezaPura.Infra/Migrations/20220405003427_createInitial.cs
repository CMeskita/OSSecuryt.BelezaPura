using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSSecuryt.BelezaPura.Infra.Migrations
{
    public partial class createInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EFEITOS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EFEITOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_SERVICOS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMECLIENTE = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    NOMECELULAR = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    NOMESERVICO = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    SERVICO_DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                   
                    EfeitosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BODY_PART = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    ValorTotalServico = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SERVICOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_SERVICOS_TB_EFEITOS_EfeitosId",
                        column: x => x.EfeitosId,
                        principalTable: "TB_EFEITOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_SERVICOS_EfeitosId",
                table: "TB_SERVICOS",
                column: "EfeitosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_SERVICOS");

            migrationBuilder.DropTable(
                name: "TB_EFEITOS");
        }
    }
}

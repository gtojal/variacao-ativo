using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtivosApi.Migrations;

/// <inheritdoc />
public partial class CriandoTabelaDeAtivo : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterDatabase()
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Ativos",
            columns: table => new
            {
                Id = table.Column<string>(type: "varchar(255)", nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                AtivoNome = table.Column<string>(type: "longtext", nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                VariacaoDiaAnterior = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                VariacaoPrimeiraData = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Ativos", x => x.Id);
            })
            .Annotation("MySql:CharSet", "utf8mb4");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Ativos");
    }
}

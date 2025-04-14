using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaNuMetroV1.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelasCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_filme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    duracao = table.Column<TimeOnly>(type: "time", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    cast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    imagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sessao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sala = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false),
                    horario = table.Column<TimeOnly>(type: "time", nullable: false),
                    tipoSessao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    acessorios = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sessao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contacto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_filme");

            migrationBuilder.DropTable(
                name: "tb_sessao");

            migrationBuilder.DropTable(
                name: "Utilizador");
        }
    }
}

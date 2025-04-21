using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaNuMetroV1.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "sala",
                table: "tb_sessao",
                type: "bigint",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "sala",
                table: "tb_sessao",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 10);
        }
    }
}

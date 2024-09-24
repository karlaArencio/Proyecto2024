using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto2024.BD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRegistro",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegistroId",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RegistroId",
                table: "Personas",
                column: "RegistroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Registros_RegistroId",
                table: "Personas",
                column: "RegistroId",
                principalTable: "Registros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Registros_RegistroId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_RegistroId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdRegistro",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RegistroId",
                table: "Personas");
        }
    }
}

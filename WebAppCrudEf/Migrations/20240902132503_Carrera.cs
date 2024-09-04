using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudEf.Migrations
{
    /// <inheritdoc />
    public partial class Carrera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarreraId",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CarreraId",
                table: "Alumnos",
                column: "CarreraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Carreras_CarreraId",
                table: "Alumnos",
                column: "CarreraId",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Carreras_CarreraId",
                table: "Alumnos");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_CarreraId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "CarreraId",
                table: "Alumnos");
        }
    }
}

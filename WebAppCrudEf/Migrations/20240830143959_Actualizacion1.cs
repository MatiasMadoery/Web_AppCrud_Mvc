using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudEf.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_AlumnoId",
                table: "Domicilios",
                column: "AlumnoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilios_Alumnos_AlumnoId",
                table: "Domicilios",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilios_Alumnos_AlumnoId",
                table: "Domicilios");

            migrationBuilder.DropIndex(
                name: "IX_Domicilios_AlumnoId",
                table: "Domicilios");
        }
    }
}

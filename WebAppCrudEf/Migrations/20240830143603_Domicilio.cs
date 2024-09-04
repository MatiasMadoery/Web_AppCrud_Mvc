using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudEf.Migrations
{
    /// <inheritdoc />
    public partial class Domicilio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "anioIngreso",
                table: "Alumnos",
                newName: "AnioIngreso");

            migrationBuilder.AddColumn<int>(
                name: "Legajo",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domicilios");

            migrationBuilder.DropColumn(
                name: "Legajo",
                table: "Alumnos");

            migrationBuilder.RenameColumn(
                name: "AnioIngreso",
                table: "Alumnos",
                newName: "anioIngreso");
        }
    }
}

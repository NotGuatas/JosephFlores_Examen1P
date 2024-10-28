using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JosephFlores_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class Inicio8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheyProtein",
                table: "Proteina",
                newName: "WheyProtein");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Proteina",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Proteina",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Proteina",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ProteinaId",
                table: "Proteina",
                newName: "ProteinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WheyProtein",
                table: "Proteina",
                newName: "WheyProtein");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Proteina",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Proteina",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Proteina",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ProteinaId",
                table: "Proteina",
                newName: "ProteinaId");
        }
    }
}
